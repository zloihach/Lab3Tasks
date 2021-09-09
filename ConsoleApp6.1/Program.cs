using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[15];
            int maxValue = -101;
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=rand.Next(-100, -1);
                Console.Write(array[i]+",");
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            Console.WriteLine("Максимальный элемент массива= "+maxValue);
        }
    }
}