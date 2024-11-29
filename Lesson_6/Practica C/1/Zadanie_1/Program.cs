using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 999: ");
            int number;

            // Ввод числа с проверкой на корректность
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999)
            {
                Console.WriteLine("Пожалуйста, введите корректное число от 0 до 999: ");
            }

            // Вычисление разрядов
            int hundreds = number / 100; // Количество сотен
            int tens = (number % 100) / 10; // Количество десятков
            int units = number % 10; // Количество единиц

            // Вывод результата
            Console.WriteLine($"Количество сотен: {hundreds}");
            Console.WriteLine($"Количество десятков: {tens}");
            Console.WriteLine($"Количество единиц: {units}");
            Console.ReadKey();
        }
    }
}