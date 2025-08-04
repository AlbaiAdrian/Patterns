namespace Observer;


// Subject
class TemperatureSensor : ISubject
{
    private List<ITemperatureObserver> _observers = new();
    private float _temperature;

    public void AddObserver(ITemperatureObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(ITemperatureObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetTemperature(float temperature)
    {
        _temperature = temperature;
        Console.WriteLine($"\nSensor: New temperature is {_temperature}°C");
        Notify();
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}