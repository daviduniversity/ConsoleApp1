using System;

class CalculateN
{
    static void Main()
    {
        int n, factorial;
        n = int.Parse(Console.ReadLine());
        factorial = 1;

        for(int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}