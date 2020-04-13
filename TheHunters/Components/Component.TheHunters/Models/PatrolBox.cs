using System.Collections.Generic;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class PatrolBox
    {
        #region CONSTRUCTOR
        public PatrolBox(PatrolBoxType type, IList<Encounter> encounters)
        {
            Type = type;
            Encounters = encounters;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public PatrolBoxType Type { get; set; }

        public IList<Encounter> Encounters { get; set; }
        #endregion PROPERTIES
    }
}