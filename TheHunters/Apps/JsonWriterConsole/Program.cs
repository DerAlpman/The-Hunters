using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Component.TheHunters.Models;
using JsonWriterConsole.Creator;
using JsonWriterConsole.Creators;

namespace JsonWriterConsole
{
    internal static class Program
    {
        private static void Main()
        {
            var configFileFolder = GetFoldersForConfigurationFiles();

            ShipListCreator.WriteShips(configFileFolder);
            UBoatModelCreator.WriteUBoatModels(configFileFolder);
            UBoatPatrolAssignmentCreator.WritePatrolAssignments(configFileFolder);
            //IList<PatrolBox> patrolBoxes = BuildPatrolBoxes();
            //WritePatrolBoxesToJson(configFileFolder, patrolBoxes);
            //IList<UBoatPatrolAssignment> uBoatPatrolAssignments = BuildUBoatPatrolAssignments();
            //WriteUBoatPatrolAssignmentToJson(configFileFolder, uBoatPatrolAssignments);
        }

        //private static void WritePatrolBoxesToJson(string configFileFolder, IList<PatrolBox> patrolBoxes)
        //{
        //    using (FileStream fileStream = new FileStream(Path.Combine(configFileFolder, "PatrolBoxes.json"), FileMode.Create))
        //    using (var utf8JsonWriter = new Utf8JsonWriter(fileStream))
        //    {
        //        JsonSerializer.Serialize<IList<PatrolBox>>(utf8JsonWriter, patrolBoxes);
        //    }
        //}

        //private static IList<PatrolBox> BuildPatrolBoxes()
        //{
        //    var patrolBoxes = new List<PatrolBox>();

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.TRANSIT, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(3, EncounterType.AIRCRAFT) },
        //        { new Encounter(12, EncounterType.SHIP) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.ARCTIC, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(3, EncounterType.SHIP) },
        //        { new Encounter(6, EncounterType.CONVOY) },
        //        { new Encounter(7, EncounterType.CONVOY) },
        //        { new Encounter(8, EncounterType.CONVOY) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.ATLANTIC, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(3, EncounterType.SHIP) },
        //        { new Encounter(6, EncounterType.CONVOY) },
        //        { new Encounter(7, EncounterType.CONVOY) },
        //        { new Encounter(9, EncounterType.CONVOY) },
        //        { new Encounter(12, EncounterType.CONVOY) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.BRITISH_ISLES, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(5, EncounterType.SHIP) },
        //        { new Encounter(6, EncounterType.ESCORTED_SHIP) },
        //        { new Encounter(8, EncounterType.SHIP) },
        //        { new Encounter(10, EncounterType.CONVOY) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.CARIBBEAN, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(4, EncounterType.SHIP) },
        //        { new Encounter(6, EncounterType.TWO_ESCORTED_SHIPS) },
        //        { new Encounter(8, EncounterType.SHIP) },
        //        { new Encounter(9, EncounterType.TANKER) },
        //        { new Encounter(10, EncounterType.TANKER) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.MEDITERRANEAN, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(3, EncounterType.AIRCRAFT) },
        //        { new Encounter(4, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(7, EncounterType.SHIP) },
        //        { new Encounter(8, EncounterType.CONVOY) },
        //        { new Encounter(10, EncounterType.TWO_ESCORTED_SHIPS) },
        //        { new Encounter(11, EncounterType.AIRCRAFT) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.NORTH_AMERICA, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(4, EncounterType.SHIP) },
        //        { new Encounter(5, EncounterType.TWO_ESCORTED_SHIPS) },
        //        { new Encounter(6, EncounterType.SHIP) },
        //        { new Encounter(8, EncounterType.TWO_ESCORTED_SHIPS) },
        //        { new Encounter(9, EncounterType.TANKER) },
        //        { new Encounter(11, EncounterType.CONVOY) },
        //        { new Encounter(12, EncounterType.TANKER) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.NORWAY, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(3, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(4, EncounterType.ESCORTED_SHIP) },
        //        { new Encounter(9, EncounterType.ESCORTED_SHIP) },
        //        { new Encounter(10, EncounterType.ESCORTED_SHIP) },
        //        { new Encounter(11, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.SPANISH_COAST, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(5, EncounterType.ESCORTED_SHIP) },
        //        { new Encounter(6, EncounterType.SHIP) },
        //        { new Encounter(7, EncounterType.SHIP) },
        //        { new Encounter(10, EncounterType.CONVOY) },
        //        { new Encounter(11, EncounterType.CONVOY) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.CAPITAL_SHIP) },
        //        { new Encounter(3, EncounterType.SHIP) },
        //        { new Encounter(6, EncounterType.CONVOY) },
        //        { new Encounter(7, EncounterType.SHIP) },
        //        { new Encounter(9, EncounterType.ESCORTED_SHIP) },
        //        { new Encounter(10, EncounterType.CONVOY) },
        //        { new Encounter(12, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.GIBRALTAR, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.ESCORT) },
        //        { new Encounter(3, EncounterType.ESCORT) },
        //        { new Encounter(4, EncounterType.AIRCRAFT) },
        //        { new Encounter(5, EncounterType.AIRCRAFT) }
        //    }));

        //    patrolBoxes.Add(new PatrolBox(PatrolBoxType.BAY_OF_BISCAY, new List<Encounter>()
        //    {
        //        { new Encounter(2, EncounterType.AIRCRAFT) },
        //        { new Encounter(3, EncounterType.AIRCRAFT) },
        //        { new Encounter(4, EncounterType.AIRCRAFT) }
        //    }));

        //    return patrolBoxes;
        //}

        private static string GetFoldersForConfigurationFiles()
        {
            Assembly currentAssem = Assembly.GetAssembly(typeof(Ship));
            var directory = Path.GetDirectoryName(currentAssem.CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(directory).Value;
            return Path.Combine(appRoot, @"..\..\Components", currentAssem.GetName().Name, "ConfigurationFiles");
        }

    }
}
