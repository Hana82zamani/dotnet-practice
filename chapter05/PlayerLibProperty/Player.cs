namespace PlayerLibProperty;

public class Player
{
    public int score;
    public int Score
    {
        get
        {
            return score;
        }
       private set
        {
            score=value;
        }
    }

    public void AddScore( int amount)
    {
        score= amount+score;
    }

}
