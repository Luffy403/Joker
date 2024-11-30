using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class bankai
    {
        static void Main(string[] args)
        {
            char[] Array = new char[3] { 'A', 'C', 'E' }; // Инициализация массива из трёх символов
            Console.WriteLine("Массив символов: ");
            foreach (char a in Array)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
