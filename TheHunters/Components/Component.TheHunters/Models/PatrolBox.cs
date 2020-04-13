using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class PatrolBox
    {
        #region CONSTRUCTOR
        public PatrolBox(PatrolBoxType type, int countRollEncounters = 1, bool resupplyCheck = false)
        {
            PatrolBoxType = type;
            CountRollEncounters = countRollEncounters;
            ResupplyCheck = resupplyCheck;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public PatrolBoxType PatrolBoxType { get; set; }

        public int CountRollEncounters { get; set; }

        public bool ResupplyCheck { get; set; }
        #endregion PROPERTIES
    }
}
