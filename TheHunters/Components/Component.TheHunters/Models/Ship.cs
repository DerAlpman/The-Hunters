using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class Ship
    {
        #region CONSTRUCTOR
        public Ship(string name, ShipType type, int tonnage)
        {
            Name = name;
            Type = type;
            Tonnage = tonnage;
            Damage = 0;
        }
        #endregion

        #region PROPERTIES
        public string Name { get; }

        public ShipType Type { get; }

        public int Tonnage { get; }

        public int Damage { get; set; }
        #endregion
    }
}
