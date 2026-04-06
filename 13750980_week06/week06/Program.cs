using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.Write("Enter the first num:");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second num:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"GCD：{calc.GCD(a, b)}");
        Console.WriteLine($"LCM：{calc.LCM(a, b)}");
    }
}
class Calculator
{
    public int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public int LCM(int a, int b)
    {
        return a / GCD(a, b) * b;
    }
}