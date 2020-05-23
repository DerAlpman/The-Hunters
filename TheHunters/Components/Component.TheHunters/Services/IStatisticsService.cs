using Component.TheHunters.Models.Charts;

namespace Component.TheHunters.Services
{
    public interface IStatisticsService
    {
        void CalculateShipStatistic(Ship ship);
    }
}