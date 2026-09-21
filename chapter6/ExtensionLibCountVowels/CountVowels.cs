namespace CountVowelsLibExtension;

public static class CountVowel
{
    public static int CountVowels(this string text)
    {
        int count =0;

        for (int i=0 ; i< text.Length; i++)
        {
            if (text[i] =='a'||text[i] =='e'||text[i] =='i'||text[i] =='o'||text[i] =='u')
            {
                count++;
            }
        }

        return count;
    }
    

}
