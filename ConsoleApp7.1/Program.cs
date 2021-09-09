using System;

namespace ConsoleApp7._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            Random rand = new Random();
            double[] array = new double[23];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
                Console.Write(array[i] + " , ");
            }

            Console.WriteLine();
            for (int b = 0; b < array.Length; b++)
            {
                if (array[b] < 0 && array[b] % 2 != 0)
                {
                    sum = sum + array[b];
                }
            }
            Console.WriteLine("Сумма элементов=  " + sum);
        }
    }
}