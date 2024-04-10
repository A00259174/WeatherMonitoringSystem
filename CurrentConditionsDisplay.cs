using WeatherMonitoringSystem.Implementations;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Implementations
{
    public class CurrentConditionsDisplay : IDisplay
    {
        private IWeatherData weatherData;

        public CurrentConditionsDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            // Display current conditions
        }

        // Other methods for current conditions display
    }
}

// Inside CurrentConditionsDisplay class
private IDisplay decoratedDisplay;
private string additionalInfo;

public CurrentConditionsDisplay(IDisplay decoratedDisplay, string additionalInfo)
{
    this.decoratedDisplay = decoratedDisplay;
    this.additionalInfo = additionalInfo;
}

public void Display()
{
    decoratedDisplay.Display();
    // Display additional info
}
