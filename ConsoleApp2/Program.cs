using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int priceKG = 9000;
            for (int i = 50; i <= 1000; i += 50)
            {
                Console.WriteLine(i + " г. = " + (i / 1000.0 * priceKG) + "рублей");
            }
        }
    }
}