using GameLibGenericConstraintNew;

Game game=GameFactory.creat<Game>();

game.Name = "Minecraft";
game.Players = 4;

Console.WriteLine(game.Name);

Console.WriteLine(game.Players);
