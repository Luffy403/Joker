using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Bankai
    {
        static void Main(string[] args)
        {
            int[] Array = new int[5]; // Создание массива из пяти элементов
            Console.WriteLine("Введите 5 целых чисел для заполнения массива:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                Array[i] = Convert.ToInt32(Console.ReadLine()); // Ввод значений вручную
            }

            // Вывод заполненного массива
            Console.WriteLine("Заполненный массив:");
            foreach (int num in Array)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
