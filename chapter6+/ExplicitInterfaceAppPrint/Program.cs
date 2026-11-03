using ExplicitInterfaceLibPrint;

MultiFunctionDevice device=new();

device.Start();
((IScanner)device).Start();