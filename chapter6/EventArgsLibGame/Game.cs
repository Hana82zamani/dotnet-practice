namespace GameLibEventArgs;

public class Game
{
   public string Name="";
public event EventHandler<ScoreEventArgs>? ScoreChanged ;

public void ChangeScore(ScoreEventArgs e)

    {
        ScoreChanged?.Invoke(this,e);
    }

}
public class ScoreEventArgs : EventArgs
{
  public int NewScore;   
}