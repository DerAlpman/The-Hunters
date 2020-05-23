using System.IO;
using System.Linq;
using Component.TheHunters.Enumerations;
using Component.TheHunters.IO;
using Component.TheHunters.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.TheHunters.TestCases
{
    [TestClass]
    public class ShipServiceTests
    {
        [TestMethod]
        [DataRow(2, ShipType.TANKER, ShipRegion.WORLD)]
        [DataRow(3, ShipType.LARGE_FREIGHTER, ShipRegion.WORLD)]
        [DataRow(1, ShipType.LARGE_FREIGHTER, ShipRegion.NORTH_AMERICA)]
        [DataRow(1, ShipType.CAPITAL_SHIP, ShipRegion.WORLD & ShipRegion.NORTH_AMERICA)]
        public void GetShips_NrAndTypeOfShips_ACollectionWithExpectedNrOfShipsAndCorrectType(int nrShips, ShipType shipType, ShipRegion appearsInRegion)
        {
            #region ARRANGE
            var loader = new JsonConfigurationFileLoader();
            var di = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(loader.GetType().Assembly.Location), "ConfigurationFiles", "Ships"));

            var ships = loader.ReadShipDataFromDirectory(di);
            var shipService = new ShipService(ships);
            #endregion

            #region ACT
            var result = shipService.GetShipsFromAvailable(nrShips, shipType, appearsInRegion);
            #endregion

            #region ASSERT
            Assert.IsTrue(result.Count == nrShips);
            Assert.IsTrue(result.All(s => s.Type == shipType));
            Assert.IsTrue(result.All(s => s.AppearsInRegion == appearsInRegion));
            #endregion
        }
    }
}
