using System.Text.Json.Serialization;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class Ship
    {
        #region CONSTRUCTOR
        internal Ship(string name, ShipType type, int tonnage)
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

        [JsonIgnore]
        public int Damage { get; set; }
        #endregion
    }
}
