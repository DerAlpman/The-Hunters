using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models.Charts
{
    public class FlakAttackvsAircraft
    {
        #region CONSTRUCTOR
        public FlakAttackvsAircraft(int rollLowerLimit, int rollUpperLimit, FlakAttackvsAircraftResult result)
        {
            this.RollLowerLimit = rollLowerLimit;
            this.RollUpperLimit = rollUpperLimit;
            this.Result = result;
        }
        #endregion

        #region PROPERTIES
        public int RollLowerLimit { get; set; }

        public int RollUpperLimit { get; set; }

        public FlakAttackvsAircraftResult Result { get; set; }
        #endregion
    }
}
