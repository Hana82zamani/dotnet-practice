
namespace StudentLibProperty;

public class Student
{
    private int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {

            if (value>20 || value < 0)
            {
                throw new ArgumentOutOfRangeException("invalid score");
            }
            score=value;
        }


    } 
}

