using DeviceLibInterfaceDefult;

Laptop laptop = new();

laptop.Start();
laptop.Stop();
IDevice device=laptop;
device.Pause();