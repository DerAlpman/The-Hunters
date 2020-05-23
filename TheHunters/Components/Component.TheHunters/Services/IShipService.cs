﻿using System.Collections.Generic;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Interfaces
{
    /// <summary>
    /// <para>Provides methods to manage the ships in the game.</para>
    /// </summary>
    public interface IShipService
    {
        /// <summary>
        /// <para>This property holds a ships available in the game.</para>
        /// </summary>
        IEnumerable<Ship> Ships { get; }
    }
}
