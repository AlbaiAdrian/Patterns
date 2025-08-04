// See https://aka.ms/new-console-template for more information
using Observer;

Console.WriteLine("Hello, Observer!");

var sensor = new TemperatureSensor();
var display = new DigitalDisplay();
var app = new MobileApp();

sensor.AddObserver(display);
sensor.AddObserver(app);

sensor.SetTemperature(25.5f);
sensor.SetTemperature(26.2f);

// Remove one observer
sensor.RemoveObserver(display);
sensor.SetTemperature(27.8f);
