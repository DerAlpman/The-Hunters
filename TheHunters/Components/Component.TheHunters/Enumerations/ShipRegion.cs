using System;

namespace Component.TheHunters.Enumerations
{
    /// <summary>
    /// <para>This enum is used to distinguish the region where a ship can appear.</para>
    /// </summary>
    [Flags]
    public enum ShipRegion
    {
        NONE = 0,
        WORLD = 1,
        NORTH_AMERICA = 2
    }
}
