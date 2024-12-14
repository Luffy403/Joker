using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число ежи: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число ежи: ");
            int secondnumber = int.Parse(Console.ReadLine());
            int sum = firstnumber + secondnumber;
            Console.WriteLine("Их сумма: " + sum);
            Console.ReadKey();
        }
    }
}
