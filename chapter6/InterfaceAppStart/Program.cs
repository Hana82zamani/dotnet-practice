using StartLibInterface;

Car car = new()
{
    Model="BMW"
};
Robot robot = new()
{
    Name="chatGBT"
};

static void startItem(Istartable item)
{
    item.Start();
}
startItem(car);
startItem(robot);