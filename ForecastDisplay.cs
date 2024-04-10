using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Implementations
{
    public class ForecastDisplay : IForecastDisplay
    {
        private IWeatherData weatherData;

        public ForecastDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            // Display forecast
        }

        // Other methods for forecast display
    }
}
