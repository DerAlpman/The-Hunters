using System.Collections.Generic;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class PatrolRegion
    {
        #region CONSTRUCTOR
        public PatrolRegion(PatrolRegions patrolRegion, IDictionary<string, PatrolBox> patrolBoxes)
        {
            Name = patrolRegion;
            PatrolBoxes = patrolBoxes;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public PatrolRegions Name { get; set; }

        public IDictionary<string, PatrolBox> PatrolBoxes { get; set; }
        #endregion PROPERTIES
    }
}