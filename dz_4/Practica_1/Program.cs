using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
        static void Main()
        {
            int[] massiv1 = { 1, 2, 3, 403 };
            int[] massiv2 = { 7, 98, 2, 4 };
            int[] megamassiv = new int[massiv1.Length + massiv2.Length];
            for (int i = 0; i < massiv1.Length; i++ )
            {
                megamassiv[i] = massiv1[i];
            }
            for (int i = 0; i < massiv2.Length; i++)
            {
                megamassiv[massiv1.Length + i] =  massiv2[i];
            }
            Console.WriteLine("Каждый элемент массива: ");
            foreach (int number in megamassiv)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
            
        }
    }
}
