using System;
namespace week05
{
    class MainClass 
    {

        public static void Main() 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Enter a year:");

            if (int.TryParse(Console.ReadLine(), out int year))
            {

                bool l = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

                if (l)
                {
                    Console.WriteLine($"{year} 是閏年");
                }
                else
                {
                    Console.WriteLine($"{year} 是平年");
                }
            }
            else 
            {
                Console.WriteLine("Error year!!!");
            }
        }
    }
}
