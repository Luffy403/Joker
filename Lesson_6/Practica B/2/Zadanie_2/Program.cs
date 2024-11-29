using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Большее число: {firstNumber}");
                Console.WriteLine($"Меньшее число: {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Большее число: {secondNumber}");
                Console.WriteLine($"Меньшее число: {firstNumber}");
            }
            else
            {
                Console.WriteLine("Оба числа равны.");
            }
            Console.ReadKey();
        }
    }
}
