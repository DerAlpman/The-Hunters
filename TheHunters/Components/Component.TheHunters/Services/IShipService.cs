using System.Collections.Generic;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Interfaces
{
    /// <summary>
    /// <para>Provides methods to manage the ships in the game.</para>
    /// </summary>
    public interface IShipService
    {
        /// <summary>
        /// <para>This method gets ships from the game's ship pool that are not sunk, yet.</para>
        /// </summary>
        /// <param name="count">The number of ships this method returns.</param>
        /// <param name="shipType">The <see cref="ShipType"/> of the returned ships.</param>
        /// <returns>A collection of <see cref="Ship"/>.</returns>
        IList<Ship> GetShipsFromAvailable(int count, ShipType shipType, ShipRegion appearsInRegion);
    }
}
