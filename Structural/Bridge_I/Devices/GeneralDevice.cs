namespace Bridge_I.Devices;

public abstract class GeneralDevice : IDevice
{
    private int _channel = 0;
    private int _volume = 0;
    private bool _hasPower;

    public abstract DeviceTypes DeviceType { get; }

    public int GetChannel()
    {
        return _channel;
    }

    public void SetChannel(int channel)
    {
        if (channel < 0 || channel > 500)
        {
            _channel = 0;
            Console.WriteLine($"Device {DeviceType} -> Channel changed to {_channel}");
            return;
        }
        
        _channel = channel;
        Console.WriteLine($"Device {DeviceType} -> Channel changed to {_channel}");
    }

    public int GetVolume()
    {
        return _volume;
    }

    public void SetVolume(int volume)
    {
        if (volume > 100)
        {
            _volume = 100;
            Console.WriteLine($"Device {DeviceType} -> Volume changed to {_volume}");
            return;
        }
        if (volume < 0)
        {
            _volume = 0;
            Console.WriteLine($"Device {DeviceType} -> Volume changed to {_volume}");
            return;
        }
        
        _volume = volume;
        Console.WriteLine($"Device {DeviceType} -> Volume changed to {_volume}");
    }

    public bool HasPower()
    {
        return _hasPower;
    }

    public void Start()
    {
        Console.WriteLine($"Device {DeviceType} -> Power on!");
        _hasPower = true;
    }

    public void Stop()
    {
        Console.WriteLine($"Device {DeviceType} -> Power off!");
        _hasPower = false;
    }
}