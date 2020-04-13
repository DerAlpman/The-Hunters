using System.Collections.Generic;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class PatrolRegion
    {
        public PatrolRegion(int roll, string name, PatrolType type, List<PatrolBox> patrolBoxes)
        {
            Roll = roll;
            Name = name;
            Type = type;
            PatrolBoxes = patrolBoxes;
        }
        #region PROPERTIES
        public string Name { get; set; }

        public int Roll { get; set; }

        public PatrolType Type { get; set; }

        public IEnumerable<PatrolBox> PatrolBoxes { get; set; }
        #endregion PROPERTIES
    }
}