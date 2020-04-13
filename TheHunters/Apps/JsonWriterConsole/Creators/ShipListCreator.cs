using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Component.TheHunters;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Models;

namespace JsonWriterConsole.Creator
{
    internal static class ShipListCreator
    {
        internal static void WriteShips(string configFileFolder)
        {
            IDictionary<string, IList<Ship>> shipLists = BuildShipLists();
            WriteShipListsToJson(configFileFolder, shipLists);
        }

        #region METHODS
        private static void WriteShipListsToJson(string configFileFolder, IDictionary<string, IList<Ship>> shipLists)
        {
            foreach (var shipList in shipLists)
            {
                using var fileStream = new FileStream(Path.Combine(configFileFolder, shipList.Key + ".json"), FileMode.Create);
                using var utf8JsonWriter = new Utf8JsonWriter(fileStream);
                JsonSerializer.Serialize<IList<Ship>>(utf8JsonWriter, shipList.Value);
            }
        }

        private static IDictionary<string, IList<Ship>> BuildShipLists()
        {
            var shipLists = new Dictionary<string, IList<Ship>>
            {
                ["CapitalShips"] = CapitalShips()
            };
            //shipLists["Tankers"] = Tankers();
            //shipLists["Optional.Tankers"] = OptionalTankers();
            //shipLists["NorthAmerica.Tankers"] = NorthAmericaTankers();
            //shipLists["SmallFreighters"] = SmallFreighters();
            //shipLists["Optional.SmallFreighters"] = OptionalSmallFreighters();
            //shipLists["NorthAmerica.SmallFreighters"] = NorthAmericaSmallFreighters();
            //shipLists["LargeFreighters"] = LargeFreighters();
            //shipLists["Optional.LargeFreighters"] = OptionalLargeFreighters();
            //shipLists["NorthAmerica.LargeFreighters"] = NorthAmericaFreighters();
            return shipLists;
        }
        private static IList<Ship> NorthAmericaFreighters()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> OptionalLargeFreighters()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> LargeFreighters()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> NorthAmericaSmallFreighters()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> OptionalSmallFreighters()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> SmallFreighters()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> NorthAmericaTankers()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> OptionalTankers()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> Tankers()
        {
            throw new NotImplementedException();
        }

        private static IList<Ship> CapitalShips()
        {
            return new List<Ship>()
            {
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 22000, "CV Ark Royal") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 29100, "BB Royal Oak") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 18600, "CV Courageous") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 10000, "CA Belfast") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 31100, "BB Barham") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 34000, "BB Nelson") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 31300, "BB Malaya") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 22600, "CV Eagle") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 12800, "CVE Avenger") },
                { ShipFactory.CreateShip(ShipType.CAPITAL_SHIP, 11000, "CVE Audacity") }
            };
        }
        #endregion METHODS
    }
}