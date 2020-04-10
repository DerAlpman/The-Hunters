using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    /// <summary>
    /// <para>The commander of a U-Boat.</para>
    /// </summary>
    public class Kommandant : CrewMember
    {
        #region CONSTRUCTOR
        public Kommandant(string firstName, string lastName, KommandantRank rank) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Rank = rank;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public string FirstName { get; }

        public string LastName { get; }

        public KommandantRank Rank { get; set; }

        public MedalRewards Decoration { get; set; }
        #endregion PROPERTIES
    }
}
