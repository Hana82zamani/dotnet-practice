namespace StudentLib4;

public class Student
{
    public (int Score, string Status)GetResult(int score)

    {
        return(score,CheckStatus(score));


        static string CheckStatus(int score)
        {
            if (score >= 18)
            {
                return "Excellent";
            }
            else if (score >=10 )
            {
                return "Pass";
            }
            else
            {
                return "fail";
            }
            
        }
    }

}
