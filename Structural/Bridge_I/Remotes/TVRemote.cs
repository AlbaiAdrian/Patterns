using Bridge_I.Devices;

namespace Bridge_I.Remotes;

public class TVRemote : GeneralRemote
{
    public TVRemote(IDevice device) : base(device) { }

    public override DeviceTypes DeviceType => DeviceTypes.TV;

    public void TogglePower()
    {
        if (_device.HasPower())
        {
            _device.Stop();
            return;
        }

        _device.Start();
    }
}
