using System;

class BiggAndOdd
{
    static void Main()
    {
        int n;
        bool result;
        n = int.Parse(Console.ReadLine());
        result = false;
        if (n > 20 && n % 10 != 0)
        {
            result = true;
        }
        Console.WriteLine(result);
    }
}