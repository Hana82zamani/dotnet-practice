namespace StudentHelperLibGeneric;

public class Student
{
    public static string CreateInfo<TName, TScore>(TName name, TScore score)
    {
        return $"Student: {name} | Score: {score}";
        
    }

}

