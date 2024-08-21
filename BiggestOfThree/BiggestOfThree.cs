using System;

class BiggestOfThree
{
    static void Main()
    {
        int a, b, c, max;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            max = a;
        }
        else if (b > a && b > c)
        {
            max = b;
        }
        else
            max = c;
        Console.WriteLine(max);
    }
}