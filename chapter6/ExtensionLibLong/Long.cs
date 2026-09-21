namespace LongLibExtension;

public static class Long 
{
    public static bool IsLong(this string text)
    {
        if(text.Length > 10)
        {
           return true;
        }
        return false;
    }

}
