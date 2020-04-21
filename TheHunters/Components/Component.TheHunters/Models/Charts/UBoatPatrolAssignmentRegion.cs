using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models.Charts
{
    public class UBoatPatrolAssignmentRegion
    {
        #region CONSTRUCTOR
        public UBoatPatrolAssignmentRegion(int roll, PatrolRegions region)
        {
            Roll = roll;
            Region = region;
        }
        #endregion

        #region PROPERTIES
        public int Roll { get; set; }

        public PatrolRegions Region { get; set; }
        #endregion
    }
}
