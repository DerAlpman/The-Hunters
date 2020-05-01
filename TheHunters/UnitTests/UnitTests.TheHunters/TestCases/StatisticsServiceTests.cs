using Component.TheHunters.Enumerations;
using Component.TheHunters.Models.Charts;
using Component.TheHunters.Models.Statistics;
using Component.TheHunters.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.TheHunters.TestCases
{
    [TestClass]
    public class StatisticsServiceTests
    {
        [TestMethod]
        public void CalculateShipStatistic_ShipStatistic_CorrectResult()
        {
            #region ARRANGE
            var statisticService = new StatisticsService();
            var ship = new Ship("Norness", ShipType.TANKER, 9100);
            var shipStatistics = new ShipStatistic(ship);
            shipStatistics.AddGunAttack(GunAttack.UnsuccessfulAttack(1));
            shipStatistics.AddGunAttack(GunAttack.UnsuccessfulAttack(1));
            shipStatistics.AddGunAttack(GunAttack.UnsuccessfulAttack(1));
            shipStatistics.AddGunAttack(GunAttack.SuccessfulAttack(1, 1));
            shipStatistics.AddGunAttack(GunAttack.SuccessfulAttack(1, 2));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.UnsuccessfulAttack(1));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.UnsuccessfulAttack(1));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.DudAttack(1));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.DudAttack(1));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.DudAttack(1));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.SuccessfulAttack(1, 3));
            shipStatistics.AddTorpedoAttack(TorpedoAttack.SuccessfulAttack(1, 4));
            #endregion

            #region ACT

            #endregion

            #region ASSERT
            #endregion
        }
    }
}
