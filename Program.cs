using System;

namespace bastaLunchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Basta! 2019"!);
            var lunchloader = new LunchLoader();
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.V)
            {
                lunchloader.PrintVegi();
            }
            else 
            {
                lunchloader.PrintMeat();
            }

        }
    }
}
