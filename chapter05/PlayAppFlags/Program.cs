using PlayLibrary;

Player player = new()
{
    Name = "Hana",
    Powers = PlayerPower.Sword | PlayerPower.Magic
};

Console.WriteLine($"Name: {player.Name}");

Console.WriteLine($"Powers: {player.Powers}");

Console.WriteLine($"Number: {(int)player.Powers}");

if (player.Powers.HasFlag(PlayerPower.Magic))
{
    Console.WriteLine("Has Magic");
}

if (player.Powers.HasFlag(PlayerPower.Sword))
{
    Console.WriteLine("Has Sword");
}
// استفاده از enum flogs