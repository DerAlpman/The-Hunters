using System.Text.Json.Serialization;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models.Charts
{
    public class Ship
    {
        #region CONSTRUCTOR
        internal Ship()
        {
        }

        internal Ship(string name, ShipType type, int tonnage)
        {
            Name = name;
            Type = type;
            Tonnage = tonnage;
            Damage = 0;
        }
        #endregion

        #region PROPERTIES
        public string Name { get; set; }

        public ShipType Type { get; }

        public int Tonnage { get; set; }

        [JsonIgnore]
        public int Damage { get; set; }

        public bool Sunk => IsSunk();
        #endregion

        private bool IsSunk()
        {
            if (CheckForSmallFreighter())
            {
                return true;
            }

            if (CheckForCapitalShip())
            {
                return true;
            }

            if (CheckForTankerOrLargeFrighter())
            {
                return true;
            }

            return false;
        }

        private bool CheckForTankerOrLargeFrighter()
        {
            return (((Type == ShipType.LARGE_FREIGHTER) || Type == ShipType.TANKER)
                && (Tonnage < 10000 && Damage >= 3)) || (Tonnage >= 10000 && Damage >= 4);
        }

        private bool CheckForCapitalShip()
        {
            return Type == ShipType.CAPITAL_SHIP && Damage >= 5;
        }

        private bool CheckForSmallFreighter()
        {
            return Type == ShipType.SMALL_FREIGHTER && Damage >= 2;
        }
    }
}
