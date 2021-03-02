using System;
using System.Text.RegularExpressions;

namespace CastlevaniaIIIPasswordSaveGen {
  public class PlayerNameNameValidator {
    private static bool ValidateNameLength(String name) {
      return name.Length <= 8;
    }

    private static String RemoveInvalidCharacters(String name) {
      String invalidCharacterRegex = "[^A-Z|^\\?|^\\.|^\\!|^ ]";
      return Regex.Replace(name, invalidCharacterRegex, String.Empty);
    }

    private static bool ValidateCharacters(String name) {
      String cleanName = RemoveInvalidCharacters(name);
      return name.Length == cleanName.Length;
    }

    public static bool Validate(String name) {
      return ValidateNameLength(name) && ValidateCharacters(name);
    }
  }
}
