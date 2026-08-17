namespace StartGameLib;

public class Game
{
 public string StartGame(string playerName = "Player",int level =1 , bool isOnline = true)
    {
         return $"Player: {playerName}, Level: {level}, Online: {isOnline}";

    }
}
