using GameInfoLib;

Game game=new();

var (Name,score,IsOnline)=game.GetGameInfo();

Console.WriteLine($"name:{Name},score{score},is online {IsOnline}");