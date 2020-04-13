using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using Component.TheHunters;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Models;

namespace JsonWriterConsole
{
    internal static class Program
    {
        private static void Main()
        {
            var configFileFolder = GetFoldersForConfigurationFiles();
            IDictionary<string, IList<Ship>> shipLists = BuildShipLists();
            WriteShipListsToJson(configFileFolder, shipLists);

            IList<PatrolBox> patrolBoxes = BuildPatrolBoxes();
            WritePatrolBoxesToJson(configFileFolder, patrolBoxes);
            //IList<UBoatPatrolAssignment> uBoatPatrolAssignments = BuildUBoatPatrolAssignments();
            //WriteUBoatPatrolAssignmentToJson(configFileFolder, uBoatPatrolAssignments);
        }

        private static void WritePatrolBoxesToJson(string configFileFolder, IList<PatrolBox> patrolBoxes)
        {
            using (FileStream fileStream = new FileStream(Path.Combine(configFileFolder, "PatrolBoxes.json"), FileMode.Create))
            using (var utf8JsonWriter = new Utf8JsonWriter(fileStream))
            {
                JsonSerializer.Serialize<IList<PatrolBox>>(utf8JsonWriter, patrolBoxes);
            }
        }

        private static IList<PatrolBox> BuildPatrolBoxes()
        {
            var patrolBoxes = new List<PatrolBox>();

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.TRANSIT, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(3, EncounterType.AIRCRAFT) },
                { new Encounter(12, EncounterType.SHIP) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.ARCTIC, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.CAPITAL_SHIP) },
                { new Encounter(3, EncounterType.SHIP) },
                { new Encounter(6, EncounterType.CONVOY) },
                { new Encounter(7, EncounterType.CONVOY) },
                { new Encounter(8, EncounterType.CONVOY) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.ATLANTIC, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.CAPITAL_SHIP) },
                { new Encounter(3, EncounterType.SHIP) },
                { new Encounter(6, EncounterType.CONVOY) },
                { new Encounter(7, EncounterType.CONVOY) },
                { new Encounter(9, EncounterType.CONVOY) },
                { new Encounter(12, EncounterType.CONVOY) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.BRITISH_ISLES, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.CAPITAL_SHIP) },
                { new Encounter(5, EncounterType.SHIP) },
                { new Encounter(6, EncounterType.ESCORTED_SHIP) },
                { new Encounter(8, EncounterType.SHIP) },
                { new Encounter(10, EncounterType.CONVOY) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.CARIBBEAN, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(4, EncounterType.SHIP) },
                { new Encounter(6, EncounterType.TWO_ESCORTED_SHIPS) },
                { new Encounter(8, EncounterType.SHIP) },
                { new Encounter(9, EncounterType.TANKER) },
                { new Encounter(10, EncounterType.TANKER) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.MEDITERRANEAN, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(3, EncounterType.AIRCRAFT) },
                { new Encounter(4, EncounterType.CAPITAL_SHIP) },
                { new Encounter(7, EncounterType.SHIP) },
                { new Encounter(8, EncounterType.CONVOY) },
                { new Encounter(10, EncounterType.TWO_ESCORTED_SHIPS) },
                { new Encounter(11, EncounterType.AIRCRAFT) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.NORTH_AMERICA, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(4, EncounterType.SHIP) },
                { new Encounter(5, EncounterType.TWO_ESCORTED_SHIPS) },
                { new Encounter(6, EncounterType.SHIP) },
                { new Encounter(8, EncounterType.TWO_ESCORTED_SHIPS) },
                { new Encounter(9, EncounterType.TANKER) },
                { new Encounter(11, EncounterType.CONVOY) },
                { new Encounter(12, EncounterType.TANKER) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.NORWAY, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(3, EncounterType.CAPITAL_SHIP) },
                { new Encounter(4, EncounterType.ESCORTED_SHIP) },
                { new Encounter(9, EncounterType.ESCORTED_SHIP) },
                { new Encounter(10, EncounterType.ESCORTED_SHIP) },
                { new Encounter(11, EncounterType.CAPITAL_SHIP) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.SPANISH_COAST, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(5, EncounterType.ESCORTED_SHIP) },
                { new Encounter(6, EncounterType.SHIP) },
                { new Encounter(7, EncounterType.SHIP) },
                { new Encounter(10, EncounterType.CONVOY) },
                { new Encounter(11, EncounterType.CONVOY) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.CAPITAL_SHIP) },
                { new Encounter(3, EncounterType.SHIP) },
                { new Encounter(6, EncounterType.CONVOY) },
                { new Encounter(7, EncounterType.SHIP) },
                { new Encounter(9, EncounterType.ESCORTED_SHIP) },
                { new Encounter(10, EncounterType.CONVOY) },
                { new Encounter(12, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.GIBRALTAR, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.ESCORT) },
                { new Encounter(3, EncounterType.ESCORT) },
                { new Encounter(4, EncounterType.AIRCRAFT) },
                { new Encounter(5, EncounterType.AIRCRAFT) }
            }));

            patrolBoxes.Add(new PatrolBox(PatrolBoxType.BAY_OF_BISCAY, new List<Encounter>()
            {
                { new Encounter(2, EncounterType.AIRCRAFT) },
                { new Encounter(3, EncounterType.AIRCRAFT) },
                { new Encounter(4, EncounterType.AIRCRAFT) }
            }));

            return patrolBoxes;
        }

        //private static void WriteUBoatPatrolAssignmentToJson(string configFileFolder, IList<UBoatPatrolAssignment> uBoatPatrolAssignments)
        //{

        //    var options = new JsonWriterOptions()
        //    {
        //        Indented = true
        //    };

        //    using (FileStream fileStream = new FileStream(Path.Combine(configFileFolder, "U-BoatPatrolAssignments.json"), FileMode.Create))
        //    using (var utf8JsonWriter = new Utf8JsonWriter(fileStream, options))
        //    {
        //        JsonSerializer.Serialize<IList<UBoatPatrolAssignment>>(utf8JsonWriter, uBoatPatrolAssignments);
        //    }
        //}

        //private static IList<UBoatPatrolAssignment> BuildUBoatPatrolAssignments()
        //{
        //    var uBoatPatrolAssignments = new List<UBoatPatrolAssignment>()
        //    {
        //        { new UBoatPatrolAssignment(
        //            new DateTime(1939,1,1), new DateTime(1940,3,31),
        //            new List<PatrolRegion>()
        //            {
        //                {new PatrolRegion(2, "Spanish Coast", PatrolType.NORMAL,
        //            new List<PatrolBox>()
        //            {
        //                {new PatrolBox("Transit") },
        //                { new PatrolBox("Transit") }
        //            }) } })
        //        },
        //        { new UBoatPatrolAssignment(
        //            new DateTime(1940,4,1), new DateTime(1940,6,30),
        //            new List<PatrolRegion>()
        //            {{new PatrolRegion(2, "Spanish Coast", PatrolType.NORMAL,
        //            new List<PatrolBox>()
        //            {
        //                {new PatrolBox("Transit") },
        //                { new PatrolBox("Transit") }
        //            } )} })
        //        }
        //    };

        //    return uBoatPatrolAssignments;
        //}

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
