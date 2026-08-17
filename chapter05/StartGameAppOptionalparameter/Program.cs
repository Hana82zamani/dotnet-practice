using StartGameLib;

Game game = new();

Console.WriteLine( game.StartGame());
Console.WriteLine(game.StartGame("Hana", 5));
Console.WriteLine(game.StartGame(isOnline: false, level: 10));