using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    /// <summary>
    /// <para>A torpedo.</para>
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
