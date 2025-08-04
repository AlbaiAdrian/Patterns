namespace Observer;

class MobileApp : ITemperatureObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Mobile App: New temperature alert: {temperature}°C");
    }
}
