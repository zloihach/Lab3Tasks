// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class Programm
    {
        static void Main(String[] args)
        {
            double a = 0, b = 4 * Math.PI, n = Math.PI / 6, f, x;
            for (x = a;
                x <= b + n;
                x += n)
            {
                f = x + 1 + Math.Sin(x - 1);
                Console.WriteLine("x = " + x + " f= " + f);
            }

            Console.ReadKey();
        }
    }
}