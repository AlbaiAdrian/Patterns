namespace Bridge_I.Devices;

public interface IDevice
{
    DeviceTypes DeviceType { get; }    

    public bool HasPower();

    public void Start();

    public void Stop();

    public int GetVolume();
    
    public void SetVolume(int volume);

    public int GetChannel();

    public void SetChannel(int channel);

}
