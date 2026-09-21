using DeviceLibInterface;

Printer printer = new()
{
    name="new printer"
};
static void ScanItem(IScannable item)
{
    item.Scan();
}
static void ConnectItem(IConnectable item)
{
    item.Connect();
}
ScanItem(printer);
ConnectItem(printer);
