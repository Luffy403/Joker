using System;
using System.Linq;

namespace Practica_A_B
{
class Program
{
    // 1. Функция сложения двух чисел
    static int Add()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        return a + b;
    }

    // 2. Функция проверки на четность
    static bool IsEven()
    {
        Console.Write("Введите число для проверки на четность: ");
        int number = int.Parse(Console.ReadLine());
        return number % 2 == 0;
    }

    // 3. Функция реверсирования строки
    static string ReverseString()
    {
        Console.Write("Введите строку для реверсирования: ");
        string s = Console.ReadLine();
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // 4. Функция нахождения максимального элемента в массиве
    static int FindMax()
    {
        Console.Write("Введите элементы массива через запятую: ");
        int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        return arr.Max();
    }

    // 5. Функция для расчета годовой зарплаты
    static decimal CalculateAnnualSalary()
    {
        Console.Write("Введите месячную зарплату: ");
        decimal salary = decimal.Parse(Console.ReadLine());
        return salary * 12;
    }

    // 6. Функция преобразования температуры из Цельсия в Фаренгейт
    static double CelsiusToFahrenheit()
    {
        Console.Write("Введите температуру в Цельсиях: ");
        double celsius = double.Parse(Console.ReadLine());
        return (celsius * 9 / 5) + 32;
    }

    // 7. Функция подсчета гласных в строке
    static int CountVowels()
    {
        Console.Write("Введите строку для подсчета гласных: ");
        string s = Console.ReadLine();
        string vowels = "Цао Цао, Я3"; // Русские гласные
        int count = 0;

        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    // 8. Функция генерации паролей
    static int GeneratePassword()
    {
        Console.Write("Введите четырехзначный пароль для взлома: ");
        string passwordToHack = Console.ReadLine();
        int count = 0;

        for (int x = 0; x <= 9; x++)
        {
            for (int y = 0; y <= 9; y++)
            {
                for (int z = 0; z <= 9; z++)
                {
                    for (int h = 0; h <= 9; h++)
                    {
                        string generatedPass = $"{x}{y}{z}{h}";
                        count++;

                        if (generatedPass == passwordToHack)
                        {
                            Console.WriteLine("Успех! Вы подобрали пароль.");
                            return count;
                        }
                    }
                }
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        // Примеры вызовов функций
        Console.WriteLine($"Сумма: {Add()}"); // Пример ввода двух чисел
        Console.WriteLine($"Четность: {IsEven()}"); // Пример проверки на четность
        Console.WriteLine($"Реверс: {ReverseString()}"); // Пример реверсирования строки
        Console.WriteLine($"Максимум: {FindMax()}"); // Пример нахождения максимума
        Console.WriteLine($"Годовая зарплата: {CalculateAnnualSalary()}"); // Пример расчета зарплаты
        Console.WriteLine($"Температура в Фаренгейте: {CelsiusToFahrenheit()}"); // Пример преобразования температуры
        Console.WriteLine($"Количество гласных: {CountVowels()}"); // Пример подсчета гласных
        Console.WriteLine($"Количество попыток для пароля: {GeneratePassword()}"); // Пример генерации паролей

        Console.ReadKey();
    }
}
}