using PrintLibExplicit;

Device device=new();

IPrinter printer= device;
printer.Start();

IScanner scanner= device;
scanner.Start();