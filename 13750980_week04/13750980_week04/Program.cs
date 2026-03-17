using System;
namespace week04
{ 
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Enter your height(cm): ");
            double h1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight(kg): ");
            double w1 = Convert.ToDouble(Console.ReadLine());

            double h2 = h1 / 100;

            double result = w1 / (h2 * h2);
            Console.WriteLine($"Your BMI is: {result:f2}");

            if (result < 18.5) Console.WriteLine("Underweight");
            else if (result < 25) Console.WriteLine("Healthy Weight");
            else if (result < 30) Console.WriteLine("Overweight");
            else Console.WriteLine("Obesity");

        }
    }
}
