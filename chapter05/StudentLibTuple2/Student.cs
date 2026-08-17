namespace StudentLib2;

public class Student
{
public (int score,string status)GetResult(int score){


        static string CheckScore(int score)
        {

            if (score >= 10)
            {
              return  $" is pass";
            }
            else
            {
                 return $" is fail";
            }


        }
        return (score,CheckScore(score));

        

    }

}
