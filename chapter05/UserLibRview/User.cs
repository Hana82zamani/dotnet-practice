namespace UserLibRview;

public class User
{
 public string Username{get; set;}="";
public bool IsActive{get; set;}
 
public ContactInfo Contact { get; set; }
};
public class Student: User
{
   public int Age;
public int CourseCount;
};
public class Admin: User
{
   public int AccessLevel;
public int LoginCount;
};

public record ContactInfo(string Email , long Phone);
 




