using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Charts
{
    public class Encounter
    {
        #region CONSTRUCTOR
        public Encounter(int roll, EncounterType type)
        {
            Roll = roll;
            EncounterType = type;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public EncounterType EncounterType { get; set; }

        public int Roll { get; set; }
        #endregion PROPERTIES
    }
}