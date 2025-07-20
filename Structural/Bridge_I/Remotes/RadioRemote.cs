using Bridge_I.Devices;

namespace Bridge_I.Remotes;

public class RadioRemote : GeneralRemote
{
    public RadioRemote(IDevice device) : base(device) { }

    public override DeviceTypes DeviceType => DeviceTypes.Radio;

    public void Mute()
    {
        _device.SetVolume(0);
    }
}
