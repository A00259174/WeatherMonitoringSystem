using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Implementations
{
    public class StatisticsDisplay : IStatisticsDisplay
    {
        private IWeatherData weatherData;

        public StatisticsDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            // Display statistics
        }

        // Other methods for statistics display
    }
}
