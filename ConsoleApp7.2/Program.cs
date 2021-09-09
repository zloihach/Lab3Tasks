using System;

namespace ConsoleApp7._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int m = 7;
            Random rand = new Random();
            int[,] array = new int [a, m];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(1,10);
                }
            }
            Console.WriteLine("$:::::::: Исходный массив ::::::::$");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i,j]+" | ");
                }
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 2;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("$:::::::: Измененный массив ::::::::$");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i,j]+" | ");
                }
            }
        }
    }
}