using NUnit.Framework;

namespace CastlevaniaIIIPasswordSaveGen.Tests {
  public class PlayerNameTests {
    [SetUp]
    public void Setup() {
    }

    [Test]
    public void has_name() {
      PlayerName playerName = new PlayerName("EXAMPLE");
      Assert.AreEqual(playerName.Name, "EXAMPLE");
    }
  }
}
