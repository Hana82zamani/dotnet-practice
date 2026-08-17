namespace GameHelperLibRview;

public class GameHelper
{
 public (string playerName,int score,bool isOnline,string status)GetPlayerResult( string playerName="player",int score=0,bool isOnline=true){
    
        static string Status(int score)
        {

           if (score >= 80)
            {
                return "Excellent";
            }  
           else if (score >= 50)
            {
                return "Good";
            }
            else 
            {
                return "Needs practice";
            
            }

           

        }
        return (playerName,score,isOnline,Status(score));
    
    }

    
}


