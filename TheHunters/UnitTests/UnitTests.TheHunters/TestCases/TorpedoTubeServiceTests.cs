using Component.TheHunters.Enumerations;
using Component.TheHunters.Interfaces;
using Component.TheHunters.Models;
using Component.TheHunters.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.TheHunters.TestCases
{
    [TestClass]
    public class TorpedoTubeServiceTests
    {
        [TestMethod]
        public void LoadTorpedoTube_WithATorpedo_TorpedoTubeIsLoaded()
        {
            #region ARRANGE
            ITorpedoTubeService torpedoTubeService = new TorpedoTubeService();
            Torpedo torpedo = new Torpedo(TorpedoType.G7a);
            TorpedoTube torpedoTube = new TorpedoTube();
            #endregion

            #region ACT
            torpedoTubeService.TryReloadTorpedoTube(torpedoTube, torpedo, out var message);
            #endregion

            #region ASSERT
            Assert.IsTrue(torpedoTube.IsLoaded(), message);
            #endregion
        }
    }
}
