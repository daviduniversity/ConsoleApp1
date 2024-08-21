using System;

class PureDivisor
{
    static void Main()
    {
        int n;
        bool result;
        n = int.Parse(Console.ReadLine());
        result = false;
        if (n % 9 ==0 || n % 11 == 0 || n % 13 == 0)
        {
            result = true;
        }
        Console.WriteLine(result);
    }
}