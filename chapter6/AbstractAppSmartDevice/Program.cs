using SmartDeviceLibAbstract;

SmartWatch smartWatch = new()
{
    Name="Apple"
};

smartWatch.ShowName();
smartWatch.Connect();
smartWatch.Recharge();