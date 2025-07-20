// See https://aka.ms/new-console-template for more information
using Bridge_I.Devices;
using Bridge_I.Remotes;

Console.WriteLine("Hello, World!");

IDevice radio = new  Radio();
IDevice tv = new TV();

RadioRemote radioRemote = new RadioRemote(radio);

radioRemote.ChannelUp(); radioRemote.ChannelUp(); radioRemote.ChannelUp(); radioRemote.ChannelUp();
radioRemote.ChannelDown();

radioRemote.VolumeUp(); radioRemote.VolumeUp(); radioRemote.VolumeUp(); radioRemote.VolumeUp();
radioRemote.Mute();


TVRemote tvRemote= new TVRemote(tv);

tvRemote.TogglePower();

tvRemote.ChannelUp();

tvRemote.VolumeDown(); tvRemote.VolumeDown();
tvRemote.VolumeUp(); tvRemote.VolumeUp(); tvRemote.VolumeUp(); tvRemote.VolumeUp(); tvRemote.VolumeUp(); tvRemote.VolumeUp(); tvRemote.VolumeUp(); tvRemote.VolumeUp();

tvRemote.VolumeDown();
tvRemote.TogglePower();


TVRemote tvRemote1= new TVRemote(radio);
tvRemote1.TogglePower();
