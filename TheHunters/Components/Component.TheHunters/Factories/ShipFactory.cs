﻿using Component.TheHunters.Enumerations;
using Component.TheHunters.Models.Charts;

namespace Component.TheHunters
{
    public static class ShipFactory
    {
        public static Ship CreateShip(ShipType shipType, int tonnage, string name)
        {
            return new Ship(name, shipType, tonnage);
        }
    }
}