using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_задача
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[10];

            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(-100, 100);

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < 10; ++i)
            {
                Console.Write(" " + a[i]);
            }
            Console.WriteLine();
            int p = 1;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > 0)
                {
                    p *= a[i];
                }
            }
            Console.WriteLine("произведение положительных элементов = "+p);
            Console.ReadKey();
        }
    }
}
