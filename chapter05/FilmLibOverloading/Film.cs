namespace FilmLibOverloading;

public class Film
{
    public string Title = "";
    public int Year;

    // Method 1: بدون پارامتر و بدون مقدار برگشتی
    public void ShowInfo()
    {
        Console.WriteLine($"{Title} and made in {Year}");
    }

    // Method 2: Overloading + یک پارامتر
    public string ShowInfo(string message)
    {
        return $"{message} Title is {Title} and made in {Year}.";
    }

    // Optional Parameter
    public string RateMovie(int rate = 5)
    {
        return $"Movie rate: {rate}";
    }
}

