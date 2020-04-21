using System;
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
    /// <para>This class creates configuration files for U-Boat patrol assignments.</para>
    /// </summary>
    internal class UBoatPatrolAssignmentCreator : IConfigFileCreator
    {
        #region IConfigFileCreator
        /// <summary>
        /// <see cref="IConfigFileCreator"/>
        /// </summary>
        public void WriteData(string configFileFolder)
        {
            var data = BuildData();
            WriteDataToJson(configFileFolder, data);
        }
        #endregion

        #region METHODS
        private static void WriteDataToJson(string configFileFolder, IList<UBoatPatrolAssignment> data)
        {
            using var fileStream = new FileStream(Path.Combine(configFileFolder, "UBoatPatrolAssignments.json"), FileMode.Create);
            using var utf8JsonWriter = new Utf8JsonWriter(fileStream);
            JsonSerializer.Serialize<IList<UBoatPatrolAssignment>>(utf8JsonWriter, data);
        }

        private static IList<UBoatPatrolAssignment> BuildData()
        {
            var uBoatPatrolAssignments = new List<UBoatPatrolAssignment>()
            {
                { FirstPeriod() },
                { SecondPeriod() },
                { ThirdPeriod() },
                { FourthPeriod() },
                { FifthPeriod() },
                { SixthPeriod() },
                { SeventhPeriod() },
                { EigthPeriod() },
            };

            return uBoatPatrolAssignments;
        }

        private static UBoatPatrolAssignment EigthPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1942, 1, 1), new DateTime(1942, 6, 30),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.MEDITERRANEAN) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.ARCTIC) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.WEST_AFRICAN_COAST) },
                }
                );
        }

        private static UBoatPatrolAssignment SeventhPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1942, 1, 1), new DateTime(1942, 6, 30),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.MEDITERRANEAN) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.ARCTIC) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.WEST_AFRICAN_COAST) },
                }
                );
        }

        private static UBoatPatrolAssignment SixthPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1942, 1, 1), new DateTime(1942, 6, 30),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.ARCTIC) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.NORTH_AMERICA_A) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.NORTH_AMERICA) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.CARIBBEAN) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.WEST_AFRICAN_COAST) },
                }
                );
        }

        private static UBoatPatrolAssignment FifthPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1941, 7, 1), new DateTime(1941, 12, 31),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.MEDITERRANEAN) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.SPANISH_COAST) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.WEST_AFRICAN_COAST) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.ARCTIC) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.MEDITERRANEAN) },
                }
                );
        }

        private static UBoatPatrolAssignment FourthPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1941, 1, 1), new DateTime(1941, 6, 30),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.SPANISH_COAST) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.ATLANTIC_W) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.WEST_AFRICAN_COAST) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.WEST_AFRICAN_COAST) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.MEDITERRANEAN) },
                }
                );
        }

        private static UBoatPatrolAssignment ThirdPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1940, 7, 1), new DateTime(1940, 12, 31),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.SPANISH_COAST) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.SPANISH_COAST) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.BRITISH_ISLES_A) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES_M) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.ATLANTIC) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.WEST_AFRICAN_COAST) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.WEST_AFRICAN_COAST) },
                }
                );
        }

        private static UBoatPatrolAssignment SecondPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1940, 4, 1), new DateTime(1940, 6, 30),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.SPANISH_COAST) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.NORWAY) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.BRITISH_ISLES_M) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.NORWAY) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.NORWAY) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.WEST_AFRICAN_COAST) },
                }
                );
        }

        private static UBoatPatrolAssignment FirstPeriod()
        {
            return new UBoatPatrolAssignment(new DateTime(1939, 1, 1), new DateTime(1940, 3, 31),
                new List<UBoatPatrolAssignmentRegion>()
                {
                    { new UBoatPatrolAssignmentRegion(2, PatrolRegions.SPANISH_COAST) },
                    { new UBoatPatrolAssignmentRegion(3, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(4, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(5, PatrolRegions.BRITISH_ISLES_M) },
                    { new UBoatPatrolAssignmentRegion(6, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(7, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(8, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(9, PatrolRegions.BRITISH_ISLES_M) },
                    { new UBoatPatrolAssignmentRegion(10, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(11, PatrolRegions.BRITISH_ISLES) },
                    { new UBoatPatrolAssignmentRegion(12, PatrolRegions.WEST_AFRICAN_COAST) },
                }
                );
        }
        #endregion METHODS
    }
}
