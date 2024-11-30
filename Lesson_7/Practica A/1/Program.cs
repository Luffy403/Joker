using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            // Инициализация массива значениями
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Элемент {i}: {numbers[i]}");
                Console.ReadKey();
            }
        }
    }
}
