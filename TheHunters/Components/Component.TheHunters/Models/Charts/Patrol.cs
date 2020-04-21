using System.Collections.Generic;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models.Charts
{
    /// <summary>
    /// <para>A patrol consists of <see cref="PatrolBox"/>. </para>
    /// </summary>
    public class Patrol
    {
        #region CONSTRUCTOR
        public Patrol(PatrolRegions patrolRegion, IDictionary<string, PatrolBox> patrolBoxes)
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