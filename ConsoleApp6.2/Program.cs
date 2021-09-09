using System;
namespace ConsoleApp6._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            double[] array = new Double[11];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
                Console.Write(array[i] + " , ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > -0.5 && array[i] < 10)
                {
                    array[i] = 0;
                    Console.Write(array[i] + " , ");
                }
                else
                {
                    Console.Write(array[i]+" , ");
                }
            }
        }
    }
}