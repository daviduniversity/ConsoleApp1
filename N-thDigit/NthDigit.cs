using System;
using System.Numerics;

class NthDigit
{
    static void Main()
    {
        int number, n, nDigit;
        number = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        int stepin = (int)Math.Pow(10, n - 1);
        nDigit = (number / stepin) % 10;
        if (nDigit == 0)
            Console.WriteLine('-');
        else
        Console.WriteLine(nDigit);
    }
}