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
            int[] number = new int[] { 3, 7, 10, 26, 40 };
            Console.WriteLine($"Второй элемент массива: {number[1]}"); 
            number[2] = 100; 
            Console.WriteLine($"Третий элемент массива после изменения: {number[2]}");
            Console.WriteLine($"Длина массива: {number.Length}");
            Console.ReadKey();
        }
    }
}
