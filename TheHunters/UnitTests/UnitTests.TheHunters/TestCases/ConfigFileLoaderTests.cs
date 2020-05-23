using System.IO;
using System.Linq;
using Component.TheHunters.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.TheHunters.TestCases
{
    [TestClass]
    public class ConfigFileLoaderTests
    {
        [TestMethod]
        [DataRow("CapitalShips.json", 10, "CV Ark Royal", 22000)]
        [DataRow("LargeFreighters.json", 100, "Sultan Star", 12300)]
        [DataRow("SmallFreighters.json", 100, "Bosnia", 1800)]
        [DataRow("Tankers.json", 100, "Inverliffey", 9400)]
        [DataRow("NorthAmerica.LargeFreighters.json", 20, "Lady Hawkins", 8000)]
        [DataRow("NorthAmerica.SmallFreighters.json", 20, "Ciltvaira", 3800)]
        [DataRow("NorthAmerica.Tankers.json", 20, "Norness", 9100)]
        [DataRow("Optional.LargeFreighters.json", 100, "El Oso", 7300)]
        [DataRow("Optional.SmallFreighters.json", 100, "Alsacien", 3800)]
        public void ReadShipData_InputJSONFile_AllShipsAreAvailable(string fileName, int countShips, string nameFirstShip, int tonnageFirstShip)
        {
            #region ARRANGE
            IConfigFileLoader loader = new ConfigFileLoader();
            var file = Path.Combine(Path.GetDirectoryName(loader.GetType().Assembly.Location), "ConfigurationFiles", "Ships", fileName);
            #endregion

            #region ACT
            var ships = loader.ReadShipData(file);
            #endregion

            #region ASSERT
            Assert.IsTrue(ships.Count() == countShips);
            Assert.IsTrue(ships.First().Name == nameFirstShip, $"Name of the first Ship should be \"{nameFirstShip}\" but is \"{ships.First().Name}\"");
            Assert.IsTrue(ships.First().Tonnage == tonnageFirstShip, $"Tonnage of the first Ship should be {tonnageFirstShip} but is {ships.First().Tonnage}");
            #endregion
        }
    }
}
