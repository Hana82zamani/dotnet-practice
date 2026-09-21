namespace ScoreLibOperator;

public class Score
{
    public int Value;

    public static int operator +(Score score1,Score score2)
    {
        return score1.Value + score2.Value;
    }

}
