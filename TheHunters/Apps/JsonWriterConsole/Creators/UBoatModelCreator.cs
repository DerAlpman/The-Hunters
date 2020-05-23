using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Component.TheHunters.Enumerations;
using Component.TheHunters.IO;
using Component.TheHunters.Models.Charts;
using Component.TheHunters.Models.UBoat;

namespace JsonWriterConsole.Creators
{
    /// <summary>
    /// <see cref="IConfigFileCreator"/>
    /// <para>This class creates configuration files for U-Boat models.</para>
    /// </summary>
    internal class UBoatModelCreator : IConfigFileCreator
    {
        #region IConfigFileCreator
        /// <summary>
        /// <see cref="IConfigFileCreator.WriteData(string)"/>
        /// </summary>
        public void WriteData(string configFileFolder)
        {
            var data = new List<UBoatModel>()
            {
                { CreateVIIA() },
                { CreateVIIB() },
                { CreateVIIC() },
                { CreateVIIC_Flak() },
                { CreateVIID() },
                { CreateIXA() },
                { CreateIXB() },
                { CreateIXC() }
            };

            WriteDataToJson(configFileFolder, data);
        }
        #endregion

        #region METHODS
        private static void WriteDataToJson(string configFileFolder, List<UBoatModel> data)
        {
            using var fileStream = new FileStream(Path.Combine(configFileFolder, "UBoatModels.json"), FileMode.Create);
            using var utf8JsonWriter = new Utf8JsonWriter(fileStream);
            var serializerOptions = new JsonSerializerOptions()
            {
                IgnoreNullValues = true
            };

            JsonSerializer.Serialize<List<UBoatModel>>(utf8JsonWriter, data, serializerOptions);
        }
        private static UBoatModel CreateIXC()
        {
            return new UBoatModel(
                UBoatModels.IXC, 252, 1120, 18.3,
                11000, 48, 54,
                new DeckGun("10.5 cm", 5), new Flak[] { new Flak("2 cm"), new Flak("3.7 cm") },
                0, 22, new DateTime(1941, 5, 1),
                12, 10, 4, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 14), new TorpedoSection(TorpedoSectionType.AFT, 2, 2),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_A, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "8", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "12", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.CARIBBEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "8", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "12", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "7", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.WEST_AFRICAN_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                }
                );
        }

        private static UBoatModel CreateIXB()
        {
            return new UBoatModel(
                UBoatModels.IXB, 251, 1032, 18.2,
                8100, 48, 8,
                new DeckGun("10.5 cm", 5), new Flak[] { new Flak("2 cm"), new Flak("3.7 cm") },
                0, 22, new DateTime(1940, 4, 1),
                12, 10, 4, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 14), new TorpedoSection(TorpedoSectionType.AFT, 2, 2),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_A, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "12", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.CARIBBEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "12", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "7", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.WEST_AFRICAN_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                }
                );
        }

        private static UBoatModel CreateIXA()
        {
            return new UBoatModel(
                UBoatModels.IXA, 251, 1032, 18.2,
                8100, 48, 8,
                new DeckGun("10.5 cm", 5), new Flak[] { new Flak("2 cm"), new Flak("3.7 cm") },
                0, 22, new DateTime(1939, 9, 1),
                12, 10, 4, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 14), new TorpedoSection(TorpedoSectionType.AFT, 2, 2),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_A, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "12", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.CARIBBEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "12", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "6", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "7", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.WEST_AFRICAN_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                }
                );
        }

        private static UBoatModel CreateVIID()
        {
            return new UBoatModel(
                UBoatModels.VIID, 252, 965, 16,
                8100, 44, 6,
                new DeckGun("8.8 cm", 10), new Flak[] { new Flak("2 cm") },
                15, 14, new DateTime(1942, 1, 1),
                8, 6, 3, new MineSection(15),
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 8), new TorpedoSection(TorpedoSectionType.AFT, 1, 1),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "7", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.MISSION) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.CARIBBEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.MISSION) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA, countRollEncounters: 2) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.WEST_AFRICAN_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "6", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST) },
                        { "7", new PatrolBox(PatrolBoxType.WEST_AFRICAN_COAST, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ARCTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ARCTIC, countRollEncounters: 2) },
                        { "6", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ARCTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.MEDITERRANEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT_OR_GIBRALTAR ) },
                        { "3", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "4", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "5", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "6", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) }
                }
                );
        }

        private static UBoatModel CreateVIIC_Flak()
        {
            return new UBoatModel(
                UBoatModels.VIICFLAK, 218, 761, 17.2,
                6500, 44, 7,
                null, new Flak[] { new Flak("2 cm"), new Flak("2 cm"), new Flak("3.7 cm") },
                0, 5, new DateTime(1943, 5, 1),
                8, 6, 3, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 0), new TorpedoSection(TorpedoSectionType.AFT, 1, 0),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_A, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "6", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ARCTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ARCTIC, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.MEDITERRANEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT_OR_GIBRALTAR ) },
                        { "3", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "4", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "5", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "6", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) }
                }
                );
        }

        private static UBoatModel CreateVIIA()
        {
            return new UBoatModel(
                UBoatModels.VIIA, 211, 626, 16,
                4300, 44, 10,
                new DeckGun("8.8 cm", 10), new Flak[] { new Flak("2 cm") },
                0, 11, new DateTime(1939, 9, 1),
                6, 5, 1, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 6), new TorpedoSection(TorpedoSectionType.AFT, 1, 0),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_A, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ARCTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ARCTIC, resupplyCheck: true) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.MEDITERRANEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT_OR_GIBRALTAR ) },
                        { "3", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "4", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "5", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "6", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) }
                }
                );
        }

        private static UBoatModel CreateVIIC()
        {
            return new UBoatModel(
                UBoatModels.VIIC, 218, 761, 17.2,
                6500, 44, 661,
                new DeckGun("8.8 cm", 10), new Flak[] { new Flak("2 cm") },
                0, 14, new DateTime(1940, 10, 1),
                8, 6, 3, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 8), new TorpedoSection(TorpedoSectionType.AFT, 1, 1),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "6", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ARCTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ARCTIC, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.MEDITERRANEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT_OR_GIBRALTAR ) },
                        { "3", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "4", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "5", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "6", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) }
                }
                );
        }

        private static UBoatModel CreateVIIB()
        {
            return new UBoatModel(
                UBoatModels.VIIB, 218, 753, 17.2,
                6500, 44, 24,
                new DeckGun("8.8 cm", 10), new Flak[] { new Flak("2 cm") },
                0, 14, new DateTime(1939, 9, 1),
                8, 6, 3, null,
                new TorpedoSection(TorpedoSectionType.FRONT, 4, 8), new TorpedoSection(TorpedoSectionType.AFT, 1, 1),
                new List<Patrol>() {
                    { new Patrol(PatrolRegions.ATLANTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ATLANTIC_W, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ATLANTIC, countRollEncounters: 3) },
                        { "6", new PatrolBox(PatrolBoxType.ATLANTIC) },
                        { "7", new PatrolBox(PatrolBoxType.ATLANTIC, resupplyCheck: true) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_M, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.BRITISH_ISLES_A, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.MISSION) },
                        { "4", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "5", new PatrolBox(PatrolBoxType.BRITISH_ISLES) },
                        { "6", new PatrolBox(PatrolBoxType.BRITISH_ISLES, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORTH_AMERICA, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "4", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "5", new PatrolBox(PatrolBoxType.NORTH_AMERICA_OR_A) },
                        { "6", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "7", new PatrolBox(PatrolBoxType.NORTH_AMERICA) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "9", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "10", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "11", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.SPANISH_COAST, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "4", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "5", new PatrolBox(PatrolBoxType.SPANISH_COAST) },
                        { "6", new PatrolBox(PatrolBoxType.SPANISH_COAST, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.NORWAY, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "4", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "5", new PatrolBox(PatrolBoxType.NORWAY) },
                        { "6", new PatrolBox(PatrolBoxType.NORWAY, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.ARCTIC, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "3", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "4", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "5", new PatrolBox(PatrolBoxType.ARCTIC) },
                        { "6", new PatrolBox(PatrolBoxType.ARCTIC, resupplyCheck: true) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) },
                    { new Patrol(PatrolRegions.MEDITERRANEAN, new Dictionary<string, PatrolBox>()
                    {
                        { "1", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) },
                        { "2", new PatrolBox(PatrolBoxType.TRANSIT_OR_GIBRALTAR ) },
                        { "3", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "4", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "5", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "6", new PatrolBox(PatrolBoxType.MEDITERRANEAN) },
                        { "7", new PatrolBox(PatrolBoxType.TRANSIT ) },
                        { "8", new PatrolBox(PatrolBoxType.TRANSIT_OR_BAY_OF_BISCAY ) }
                        }
                    ) }
                }
                );
        }
        #endregion METHODS
    }
}