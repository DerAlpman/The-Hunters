using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    /// <summary>
    /// <para>A torpedo that can be in <see cref="TorpedoSection.Reloads"/> or in <see cref="TorpedoSection.TorpedoTubes"/>.</para>
    /// </summary>
    public class Torpedo
    {
        #region CONSTRUCTOR
        public Torpedo(TorpedoType type)
        {
            Type = type;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public TorpedoType Type { get; }
        #endregion
    }
}
