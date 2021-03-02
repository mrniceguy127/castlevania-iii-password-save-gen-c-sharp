using System;

namespace CastlevaniaIIIPasswordSaveGen {
  public class PlayerName {
    private String _name;

    public PlayerName(String name) {
      if (!PlayerNameNameValidator.Validate(name)) {
        throw new ArgumentException("Invalid player name!");
      }

      _name = name;
    }

    public String Name
    {
      get {
        return _name;
      }
    }
  }
}
