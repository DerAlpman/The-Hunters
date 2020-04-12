using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using Component.TheHunters;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Models;

namespace ShipJsonWriterConsole
{
    internal static class Program
    {
        private static void Main()
        {
            var configFileFolder = GetFoldersForConfigurationFiles();
            IDictionary<string, IList<Ship>> shipLists = BuildShipLists();
            WriteShipListsToJson(configFileFolder, shipLists);
        }

        private static void WriteShipListsToJson(string configFileFolder, IDictionary<string, IList<Ship>> shipLists)
        {
            foreach (var shipList in shipLists)
            {
                using (FileStream fileStream = new FileStream(Path.Combine(configFileFolder, shipList.Key + ".json"), FileMode.Create))
                using (var utf8JsonWriter = new Utf8JsonWriter(fileStream))
                {
                    JsonSerializer.Serialize<IList<Ship>>(utf8JsonWriter, shipList.Value);
                }
            }
        }

        private static IDictionary<string, IList<Ship>> BuildShipLists()
        {
            IDictionary<string, IList<Ship>> shipLists = new Dictionary<string, IList<Ship>>();

            shipLists["CapitalShips"] = CapitalShips();
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

        private static string GetFoldersForConfigurationFiles()
        {
            Assembly currentAssem = Assembly.GetAssembly(typeof(Ship));
            var directory = Path.GetDirectoryName(currentAssem.CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(directory).Value;
            return Path.Combine(appRoot, @"..\..\Components", currentAssem.GetName().Name, "ConfigurationFiles");
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
    }
}
