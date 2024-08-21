using System;

class SignOfProduct
{
    static void Main()
    {
        float a, b, c;
        char product;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());

        if (a * b * c < 0)
            product = '-';
        else
            product = '+';

        Console.WriteLine(product);
    }
}