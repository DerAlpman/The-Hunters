using System;
using System.Collections.Generic;
using System.Linq;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Interfaces;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Services
{
    /// <summary>
    /// <see cref="IShipService"/>
    /// </summary>
    public class ShipService : IShipService
    {
        #region FIELDS
        private readonly IEnumerable<Ship> _Ships;
        #endregion

        #region CONSTRUCTOR
        public ShipService(IEnumerable<Ship> ships)
        {
            _Ships = ships;
        }
        #endregion

        #region IShipService
        /// <summary>
        /// <see cref="IShipService.GetShipsFromAvailable(int, ShipType, ShipRegion)"/>
        /// </summary>
        public IList<Ship> GetShipsFromAvailable(int count, ShipType shipType, ShipRegion appearsInRegion)
        {
            var ships = new List<Ship>();
            var shipsOfType = _Ships.Where(s => s.Type == shipType && s.AppearsInRegion == appearsInRegion && !s.Sunk).ToList();
            var rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                ships.Add(SelectRandomShip(shipsOfType, rnd));
            }

            return ships;
        }
        #endregion IShipService

        #region ShipService
        private Ship SelectRandomShip(IList<Ship> ships, Random rnd)
        {
            int i = rnd.Next(0, ships.Count);
            var ship = ships[i];
            if (ship.AlreadySelected)
            {
                ship = SelectRandomShip(ships, rnd);
            }
            else
            {
                ship.AlreadySelected = true;
            }
            return ship;
        }
        #endregion ShipService
    }
}