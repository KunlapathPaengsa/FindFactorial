using System.Numerics;

class Program1
{
    static void Factorial1(int n)
    {
        Console.WriteLine("0! = 1");
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * (UInt128)i;
            Console.WriteLine($"{i}! = {result}");
        }
    }

    static void test1()
    {
        int n = 0;
        Console.Write("Input number of factorial : ");
        if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
        {
            Factorial1(n);
            Console.ReadKey();
        }
        Console.WriteLine("Please input a non-negative integer.");
    }
}
