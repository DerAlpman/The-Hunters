using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models.Charts
{
    public class Encounter
    {
        #region CONSTRUCTOR
        public Encounter(PatrolBoxType region, int roll, EncounterType type)
        {
            Region = region;
            Roll = roll;
            EncounterType = type;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public EncounterType EncounterType { get; set; }

        public int Roll { get; set; }

        public PatrolBoxType Region { get; set; }
        #endregion PROPERTIES
    }
}