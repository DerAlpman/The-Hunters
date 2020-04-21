using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Component.TheHunters.Enumerations;
using Component.TheHunters.Models.Charts;
using JsonWriterConsole.Creator;

namespace JsonWriterConsole.Creators
{
    /// <summary>
    /// <see cref="IConfigFileCreator"/>
    /// <para>This class creates configuration files for the encounter chart.</para>
    /// </summary>
    internal class EncounterChartCreator : IConfigFileCreator
    {
        #region IConfigFileCreator
        /// <summary>
        /// <see cref="IConfigFileCreator.WriteData(string)"/>
        /// </summary>
        public void WriteData(string configFileFolder)
        {
            var data = BuildData();
            WriteDataToJson(configFileFolder, data);
        }
        #endregion IConfigFileCreator

        #region METHODS
        private void WriteDataToJson(string configFileFolder, IList<Encounter> data)
        {
            using var fileStream = new FileStream(Path.Combine(configFileFolder, "EncounterChart.json"), FileMode.Create);
            using var utf8JsonWriter = new Utf8JsonWriter(fileStream);
            JsonSerializer.Serialize(utf8JsonWriter, data);
        }

        private IList<Encounter> BuildData()
        {
            List<Encounter> encounters = new List<Encounter>();
            encounters.AddRange(Transit());
            encounters.AddRange(Arctic());
            encounters.AddRange(Atlantic());
            encounters.AddRange(BritischIsles());
            encounters.AddRange(Carribean());
            encounters.AddRange(Mediterranean());
            encounters.AddRange(NorthAmerica());
            encounters.AddRange(Norway());
            encounters.AddRange(SpanishCoast());
            encounters.AddRange(WestAfricanCoast());
            encounters.AddRange(Gibraltar());
            encounters.AddRange(AddlRoundOfCombat());
            encounters.AddRange(BayOfBiscay());
            encounters.AddRange(SpecialMissions());

            return encounters;
        }

        private IEnumerable<Encounter> SpecialMissions()
        {
            yield return new Encounter(PatrolBoxType.MISSION, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.MISSION, 3, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.MISSION, 4, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> BayOfBiscay()
        {
            yield return new Encounter(PatrolBoxType.BAY_OF_BISCAY, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.BAY_OF_BISCAY, 3, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.BAY_OF_BISCAY, 4, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> AddlRoundOfCombat()
        {
            yield return new Encounter(PatrolBoxType.ADDL_ROUND_OF_COMBAT, 2, EncounterType.ESCORT);
            yield return new Encounter(PatrolBoxType.ADDL_ROUND_OF_COMBAT, 3, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.ADDL_ROUND_OF_COMBAT, 4, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.ADDL_ROUND_OF_COMBAT, 5, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> Gibraltar()
        {
            yield return new Encounter(PatrolBoxType.GIBRALTAR, 2, EncounterType.ESCORT);
            yield return new Encounter(PatrolBoxType.GIBRALTAR, 3, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.GIBRALTAR, 4, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.GIBRALTAR, 5, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> WestAfricanCoast()
        {
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 2, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 3, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 6, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 7, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 9, EncounterType.ESCORTED_SHIP);
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 10, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.WEST_AFRICAN_COAST, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> SpanishCoast()
        {
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 5, EncounterType.ESCORTED_SHIP);
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 6, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 7, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 10, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 11, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.SPANISH_COAST, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> Norway()
        {
            yield return new Encounter(PatrolBoxType.NORWAY, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.NORWAY, 3, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.NORWAY, 4, EncounterType.ESCORTED_SHIP);
            yield return new Encounter(PatrolBoxType.NORWAY, 9, EncounterType.ESCORTED_SHIP);
            yield return new Encounter(PatrolBoxType.NORWAY, 10, EncounterType.ESCORTED_SHIP);
            yield return new Encounter(PatrolBoxType.NORWAY, 11, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.NORWAY, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> NorthAmerica()
        {
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 4, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 5, EncounterType.TWO_ESCORTED_SHIPS);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 6, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 8, EncounterType.TWO_SHIPS);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 9, EncounterType.TANKER);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 11, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.NORTH_AMERICA, 12, EncounterType.TANKER);
        }

        private IEnumerable<Encounter> Mediterranean()
        {
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 3, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 4, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 7, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 8, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 10, EncounterType.TWO_ESCORTED_SHIPS);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 11, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.MEDITERRANEAN, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> Carribean()
        {
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 4, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 6, EncounterType.TWO_ESCORTED_SHIPS);
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 8, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 9, EncounterType.TANKER);
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 10, EncounterType.TANKER);
            yield return new Encounter(PatrolBoxType.CARIBBEAN, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> BritischIsles()
        {
            yield return new Encounter(PatrolBoxType.BRITISH_ISLES, 2, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.BRITISH_ISLES, 5, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.BRITISH_ISLES, 6, EncounterType.ESCORTED_SHIP);
            yield return new Encounter(PatrolBoxType.BRITISH_ISLES, 8, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.BRITISH_ISLES, 10, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.BRITISH_ISLES, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> Atlantic()
        {
            yield return new Encounter(PatrolBoxType.ATLANTIC, 2, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.ATLANTIC, 3, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.ATLANTIC, 6, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.ATLANTIC, 7, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.ATLANTIC, 9, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.ATLANTIC, 12, EncounterType.CONVOY);
        }

        private IEnumerable<Encounter> Arctic()
        {
            yield return new Encounter(PatrolBoxType.ARCTIC, 2, EncounterType.CAPITAL_SHIP);
            yield return new Encounter(PatrolBoxType.ARCTIC, 3, EncounterType.SHIP);
            yield return new Encounter(PatrolBoxType.ARCTIC, 6, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.ARCTIC, 7, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.ARCTIC, 8, EncounterType.CONVOY);
            yield return new Encounter(PatrolBoxType.ARCTIC, 12, EncounterType.AIRCRAFT);
        }

        private IEnumerable<Encounter> Transit()
        {
            yield return new Encounter(PatrolBoxType.TRANSIT, 2, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.TRANSIT, 3, EncounterType.AIRCRAFT);
            yield return new Encounter(PatrolBoxType.TRANSIT, 12, EncounterType.SHIP);
        }
        #endregion
    }
}
