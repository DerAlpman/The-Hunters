using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models.UBoat
{
    public class UBoat
    {
        #region PROPERTIES
        public UBoatModel Type { get; }

        public string Id { get; }

        public Kommandant Kommandant { get; set; }

        public CrewMember WO1 { get; }

        public CrewMember WO2 { get; }

        public CrewMember LI { get; }

        public CrewMember Doctor { get; }

        public CrewMember Abwehr { get; }

        public CrewMember[] Crew { get; }

        public CrewQuality CrewQuality { get; set; }

        public bool? InPort { get; set; }

        public int HullDamage { get; set; }

        public int FloodingDamage { get; set; }
        #endregion
    }
}
