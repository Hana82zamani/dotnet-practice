
namespace Ch04Ex02PrimeFactorsLib;
public static class PrimeFactors
{
    public static string GetFactors(int number)
    {
        if(number == 1)
        {
           return "1";
        }
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof (number),
            "number must be greater than zero"
            );

        }
        List<int> factors = new();
        int divisor = 2;

    while (number > 1){
        

        while (number % divisor == 0)
{
    factors.Add(divisor);
    number /= divisor;
}

  divisor++;
        }

     return string.Join(" x ", factors);
    }

}



