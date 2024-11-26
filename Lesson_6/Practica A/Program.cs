using System;

namespace Practica_A_1
{
    class Program
    {
        static void Main()
        {
            // Запросите у пользователя ввести свое имя
            Console.Write("Введите ваше имя: ");
            string имя = Console.ReadLine(); // Сохраняем имя в переменной

            // Выводим приветствие с использованием переменной
            Console.WriteLine($"Васап, {имя}! Добро пожаловать!");
            Console.ReadKey();
        }
    }
}

/*
namespace Practica_A_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваш год рождения: ");
            int yearOfBirth;


            while (!int.TryParse(Console.ReadLine(), out yearOfBirth) || yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
            {
                Console.Write("Пожалуйста, введите корректный год рождения: ");
            }


            int currentYear = DateTime.Now.Year;


            int age = currentYear - yearOfBirth;

            Console.WriteLine($"Ваш возраст жи ес: {age} лет.");
            Console.ReadKey();
        }
    }
}

*/