using System;
using NUnit.Framework; 

namespace CastlevaniaIIIPasswordSaveGen.Tests {
  public class PlayerNameNameValidatorTests {
    [Test]
    public void valid_name() {
       AssertValid("EXAMPLE");
    }

    [Test]
    public void name_greater_than_8_characters() {
      AssertInvalid("EXAMPLEEE");
    }

    [Test]
    public void name_is_8_characters() {
      AssertValid("EXAMPLEE");
    }

    [Test]
    public void name_is_less_than_8_characters() {
      AssertValid("EXAMPLE");
    }

    [Test]
    public void name_is_zero_characters() {
      AssertValid("");
    }

    [Test]
    public void name_is_many_characters() {
      AssertInvalid("EXAMPLEEXAMPLEEXAMPLE");
    }

    [Test]
    public void name_is_all_upper_case() {
      AssertValid("EXAMPLE");
    }

    [Test]
    public void name_is_all_lower_case() {
      AssertInvalid("example");
    }

    [Test]
    public void name_contains_mixed_casing() {
      AssertInvalid("ExAmPlE");
    }

    [Test]
    public void name_can_contain_space() {
      AssertValid("EXA MPLE");
    }

    [Test]
    public void name_can_contain_many_spaces() {
      AssertValid("E X A M ");
    }

    [Test]
    public void valid_symbols() {
      AssertValid("EXAMPLE!");
      AssertValid("EXAMPLE?");
      AssertValid("EXAMPLE.");
    }

    [Test]
    public void invalid_symbols() {
      AssertInvalid("EXAMPLE)");
      AssertInvalid("EXAMPLE<");
      AssertInvalid("EXAMPLE%");
    }

    [Test]
    public void many_valid_symbols() {
      AssertValid("!?.?.!?!");
    }

    [Test]
    public void many_invalid_symbols() {
      AssertInvalid("><)(^&*%");
    }

    [Test]
    public void valid_and_invalid_symbol() {
      AssertInvalid("Ex.>");
    }

    [Test]
    public void many_invalid_and_valid_symbols() {
      AssertInvalid(">.!?/.*(");
      AssertInvalid(">.!?.??!");
      AssertInvalid(".><)(*%^");
    }

    [Test]
    public void all_valid_characters() {
      AssertValid("E . ? ! ");
    }

    [Test]
    public void many_valid_characters_and_one_invalid_character() {
      AssertInvalid("E . ?>!");
    }

    [Test]
    public void many_valid_and_many_invalid_characters() {
      AssertInvalid("E^.)? !^");
    }

    private bool Validate(String name) {
      return PlayerNameNameValidator.Validate(name);
    }

    private void AssertValid(String name) {
      Assert.True(Validate(name));
    }

    private void AssertInvalid(String name) {
      Assert.False(Validate(name));
    }
  }
}
