using System;

namespace Game
{
    class Program
    {
        static void Main()
        {
            Random random403 = new Random();
            int secretNumber = random403.Next(1, 11);
            int number;
            int popitka = 0;

            Console.WriteLine("Я загадал число от 1 до 10. Попробуйте угадать его!");
            do
            {
                Console.Write("Введите ваше предположение: ");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    popitka++;
                    if (number < secretNumber)
                        Console.WriteLine("Загаданное число больше.");
                    else if (number > secretNumber)
                        Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Введите корректное целое число.");
                }
            } 
            while (number != secretNumber);
            
            Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {popitka} попыток.");
            Console.ReadKey();
        }
    }
}