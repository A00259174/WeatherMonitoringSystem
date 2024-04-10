using System.Collections.Generic;
using WeatherMonitoringSystem.Implementations;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Implementations
{
    public class WeatherData : IWeatherData
    {
        private static WeatherData instance;
        private List<IDisplay> observers = new List<IDisplay>();

        private WeatherData() { }

        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        public void RegisterObserver(IDisplay display)
        {
            observers.Add(display);
        }

        public void RemoveObserver(IDisplay display)
        {
            observers.Remove(display);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }

        // Other methods for weather data collection and updates
    }
}// Inside WeatherData class
private static WeatherData instance;
private WeatherData() { }

public static WeatherData GetInstance()
{
    if (instance == null)
    {
        instance = new WeatherData();
    }
    return instance;
}

// Inside WeatherData class
private List<IDisplay> observers = new List<IDisplay>();

public void RegisterObserver(IDisplay display)
{
    observers.Add(display);
}

public void RemoveObserver(IDisplay display)
{
    observers.Remove(display);
}

public void NotifyObservers()
{
    foreach (var observer in observers)
    {
        observer.Display();
    }
}

// Method to update weather data and notify observers
public void SetMeasurements(float temperature, float humidity, float pressure)
{
    // Set new measurements
    // Notify observers
    NotifyObservers();
}


