namespace WeatherMonitoringSystem.Interfaces
{
    public interface IWeatherData
    {
        void RegisterObserver(IDisplay display);
        void RemoveObserver(IDisplay display);
        void NotifyObservers();
    }
}
