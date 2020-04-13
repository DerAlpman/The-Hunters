using System;
using System.Collections.Generic;

namespace Component.TheHunters.Models
{
    public class UBoatPatrolAssignment
    {
        #region CONSTRUCTOR
        public UBoatPatrolAssignment(DateTime dateStart, DateTime dateEnd, List<PatrolRegion> patrolRegions)
        {
            DateStart = dateStart;
            DateEnd = dateEnd;
            PatrolRegions = patrolRegions;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public IEnumerable<PatrolRegion> PatrolRegions { get; set; }
        #endregion PROPERTIES
    }
}
