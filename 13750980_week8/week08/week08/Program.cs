using System;

class Program
{
    static void Main()
    {
        int target = new Random().Next(1, 11);
        int guess = 0;

        Console.WriteLine("Guess 1-10:");

        while (guess != target)
        {
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == target) Console.WriteLine("You did it!");
                else Console.WriteLine("Wrong! Try again~");
            }
        }
    }
}
