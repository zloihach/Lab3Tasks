/*using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp7._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int diagonal = 6;
            int[,] array = new int[6, 6];
            int a = 6, b = 6;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; b++)
                {
                    array[i, j] = rand.Next(1, 10);
                }
            }

            Console.WriteLine("$:::::::: Исходный массив ::::::::$");


            for (int i = 0; i < a; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < b; j++)
                {
                    Console.Write(array[i, j] + " | ");
                }
            }
            
            Console.WriteLine("Введите целое число K  =  ");
            int k = Convert.ToInt32(Console.ReadLine());

            List<int> massive2 = new List<int>();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < diagonal; j++)
                {
                    if (array[i, j] <= k && array[i, j] > i + j)
                    {
                        massive2.Add(array[i, j]);
                        Console.Write(array[i, j] + " | ");
                        diagonal--;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("++Итоговый массив++");
            foreach (int i in massive2)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/

using System;
using System.Collections.Generic;

namespace ConsoleApp7._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 6;
            Random rand = new Random();
            int[,] array = new int [n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(1,10);
                }
            }
            Console.WriteLine("$:::::::: Исходный массив ::::::::$");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i,j]+" | ");
                }
            }
            List<int> array2 = new List<int>();
            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n - 1)
                    {
                        array2.Add(array[i,j]);
                    }
                }
            }
            Console.WriteLine("+++++Итоговый одномерный массив+++++");
            foreach (int i in array2)
            {
                Console.Write(i);
            }
        }
    }
}