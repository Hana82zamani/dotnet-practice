namespace ScoreManagerLib;

public class ScoreManager
{
    public static void AddScore(ref int score)
    {
        score=score+10;
    }

    public static void GetBonus(out int bonus)
    {
        bonus=100;
    }


}
