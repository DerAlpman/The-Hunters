using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    /// <summary>
    /// <para>A TorpedoSection has some <see cref="TorpedoTube"/> that can contain <see cref="Torpedo"/>. <see cref="Reloads"/> contains <see cref="Torpedo"/> that can be loaded in a <see cref="TorpedoTube"/>.</para>
    /// <para><see cref="Type"/> specifies if the TorpedoSecion is in the front or in the aft (<see cref="TorpedoSectionType"/>).</para>
    /// </summary>
    public class TorpedoSection
    {
        #region CONSTRUCTOR
        public TorpedoSection(TorpedoSectionType type, int torpedoTubes, int reloads)
        {
            Type = type;
            TorpedoTubes = new TorpedoTube[torpedoTubes];
            Reloads = new Torpedo[reloads];
        }
        #endregion

        #region PROPERTIES
        public TorpedoSectionType Type { get; set; }

        public TorpedoTube[] TorpedoTubes { get; set; }

        public Torpedo[] Reloads { get; set; }
        #endregion
    }
}
