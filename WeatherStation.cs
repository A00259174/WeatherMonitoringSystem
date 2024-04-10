using WeatherMonitoringSystem.Interfaces;
using WeatherMonitoringSystem.Implementations;

namespace WeatherMonitoringSystem
{
    public class WeatherStation
    {
        public IDisplay CreateDisplay(string displayType)
        {
            if (displayType.Equals("CurrentConditions"))
            {
                return new CurrentConditionsDisplay(WeatherData.GetInstance());
            }
            else if (displayType.Equals("Statistics"))
            {
                return new StatisticsDisplay(WeatherData.GetInstance());
            }
            else if (displayType.Equals("Forecast"))
            {
                return new ForecastDisplay(WeatherData.GetInstance());
            }
            else
            {
                return null;
            }
        }
    }
}
