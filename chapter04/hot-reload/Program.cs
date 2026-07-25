while (true)
{
    Console.WriteLine("A");
    await Task.Delay(3000);
    Console.WriteLine("B");
    await Task.Delay(3000);

}