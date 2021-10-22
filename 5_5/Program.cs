using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (j % 2 == 0)
                        {
                            t[i, j] = 1;
                            Console.Write("{0,3} ", t[i, j]);
                        }
                        else
                        {
                            t[i, j] = 0;
                            Console.Write("{0,3} ", t[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (j % 2 == 0)
                        {
                            t[i, j] = 0;
                            Console.Write("{0,3} ", t[i, j]);
                        }
                        else
                        {
                            t[i, j] = 1;
                            Console.Write("{0,3} ", t[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
