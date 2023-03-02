static string PrimeFactorizing(long number)
{
    string primeNumbers = "";
    int min = 2;
    long max = number;

    while (min < max)
    {
        if (max % min == 0)
        {
            primeNumbers+= min + "*";
            max = max/min;
        }
        else
        {
            min++;
        }
    }

    primeNumbers += max;
    if (primeNumbers == max.ToString())
    {
        return (number + " is a prime number");
    }
    else
    {
        return primeNumbers;
    }

}

long input = long.Parse(Console.ReadLine());

Console.WriteLine(PrimeFactorizing(input));
//long my beloved