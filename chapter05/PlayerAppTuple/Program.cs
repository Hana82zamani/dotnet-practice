using PlayerLibTuple;

Player player=new();

var(name,score,isonline)=player.GetPlayerInfo();

 
Console.WriteLine($"{name},{score},{isonline}");
