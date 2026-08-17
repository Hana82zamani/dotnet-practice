namespace GameLib2;

public class Game
{
 public string StartGameInfo(string PlayerName="player",int Level=1,bool IsOnline=true){
   
   return $"name:{PlayerName},level:{Level},is online :{IsOnline}";
 }
}
