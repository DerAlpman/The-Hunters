using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class CrewMember
    {
        #region CONSTRUCTOR
        public CrewMember()
        {
            Status = CrewMemberStatus.HEALTHY;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public CrewMemberStatus Status { get; set; }
        #endregion
    }
}
