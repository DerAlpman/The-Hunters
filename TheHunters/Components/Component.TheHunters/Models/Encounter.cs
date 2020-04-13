using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class Encounter
    {
        #region CONSTRUCTOR
        public Encounter(int roll, EncounterType type)
        {
            Roll = roll;
            Type = type;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public EncounterType Type { get; set; }

        public int Roll { get; set; }
        #endregion PROPERTIES
    }
}