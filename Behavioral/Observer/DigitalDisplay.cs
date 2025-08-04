namespace Observer;

class DigitalDisplay : ITemperatureObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Digital Display: Temperature updated to {temperature}°C");
    }
}
