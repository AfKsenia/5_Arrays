using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 7;
            double[] array = new double[m];
            int i;
            double S = 0;
            for (i = 0; i < m; i++)
            {
                Console.WriteLine("Введите число {0}", i + 1);
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (i = 0; i < m; i++)
            {
                S += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов массива = {0:f2}", S / m);
            Console.ReadKey();
        }
    }
}
