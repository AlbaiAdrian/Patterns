using Bridge_I.Devices;

namespace Bridge_I.Remotes;

public abstract class GeneralRemote
{
    protected IDevice _device;

    public GeneralRemote(IDevice device)
    {
        _device = device;
        if (_device.DeviceType != DeviceType)
        {
            throw new Exception("Wrong type of remote for given device!");
        }
    }

    public abstract DeviceTypes DeviceType { get; }

    public void VolumeUp()
    {
        _device.SetVolume(_device.GetVolume() + 10);
    }

    public void VolumeDown()
    {
        _device.SetVolume(_device.GetVolume() - 10);
    }

    public void ChannelUp() {
        _device.SetChannel(_device.GetChannel() +1 );
    }

    public void ChannelDown()
    {
        _device.SetChannel(_device.GetChannel() - 1);
    }
}
