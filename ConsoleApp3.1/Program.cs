using System;

namespace ConsoleApp3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            if (count > 0 & count < 11) Console.WriteLine("Первая декада");
            else if (count > 10 & count < 21) Console.WriteLine("Вторая декада");
            else if (count > 20 & count < 32) Console.WriteLine("Третья декада");
            else Console.WriteLine("Число выходит за границы месяца");
        }
    }
}
;