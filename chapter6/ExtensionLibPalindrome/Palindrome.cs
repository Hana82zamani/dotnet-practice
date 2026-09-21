namespace PalindromeLibExtension;

public static class Palindrome
{
    public static bool IsPalindrome(this string text)
    {
    for(int i =0; i < text.Length/2; i++)
{
    if (text[i] != text[text.Length-1 -i ])
    {
        return false;
    }
}
    return true;
        
    }
    

}
