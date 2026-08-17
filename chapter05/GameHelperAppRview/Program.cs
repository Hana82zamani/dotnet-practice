using GameHelperLibRview;

GameHelper gameHelper=new();

var(playerName,score,isOnline,status)=gameHelper.GetPlayerResult("hana",90);

Console.WriteLine($"{playerName}:{score} {isOnline} {status}");