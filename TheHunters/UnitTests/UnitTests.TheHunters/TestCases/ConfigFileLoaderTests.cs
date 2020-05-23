using System.IO;
using System.Linq;
using Component.TheHunters.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.TheHunters.TestCases
{
    [TestClass]
    public class ConfigFileLoaderTests
    {
        #region CONSTS
        private const int TOTAL_NUMBER_OF_SHIPS = 570;
        #endregion
        [TestMethod]
        public void ReadShipData_InputJSONFile_AllShipsAreAvailable()
        {
            #region ARRANGE
            IConfigurationFileLoader loader = new JsonConfigurationFileLoader();
            var di = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(loader.GetType().Assembly.Location), "ConfigurationFiles", "Ships"));
            #endregion

            #region ACT
            var ships = loader.ReadShipDataFromDirectory(di);
            #endregion

            #region ASSERT
            Assert.IsTrue(ships.Count() == TOTAL_NUMBER_OF_SHIPS);
            #endregion
        }
    }
}
