namespace UserLibCasting;

public class User
{
    public string Username="";

    public void ShowUser()
    {
        Console.WriteLine(Username);
    }

}
public class StudentUser : User
{
    public int Grade;
}
public class TeacherUser : User
{
    public string Subject="";
}
