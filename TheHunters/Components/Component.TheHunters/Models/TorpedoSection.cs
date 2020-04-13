using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
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
