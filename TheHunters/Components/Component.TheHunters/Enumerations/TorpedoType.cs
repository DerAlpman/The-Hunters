using System.ComponentModel;

namespace Component.TheHunters.Enumerations
{
    /// <summary>
    /// <para>This enumeration represents the type of a torpedo.</para>
    /// </summary>
    public enum TorpedoType
    {
        [Description("A steam torpedo.")]
        G7a,
        [Description("An electric torpedo.")]
        G7e
    }
}
