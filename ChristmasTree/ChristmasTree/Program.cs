using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {

            //int noOfRows = int.Parse(Console.ReadLine());
            free_sp(10);
            Console.WriteLine("^");
            PyramidDef(4, 0, 11);
            PyramidDef(5, 2, 11);
            PyramidDef(7, 3, 11);
            func_l(5);

            Console.ReadLine();
        }

        private static void PyramidDef(int noOfRows, int PyramidSummit, int y)
        {
            int row, colSpace, colStar;
            int balance = 0;

            if (PyramidSummit != 0)
                balance = PyramidSummit / 2;
            for (row = 1; row <= noOfRows; row++)
            {
                for (colSpace = y - row - balance; colSpace >= 1; colSpace--)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (colStar = 1; colStar <= (row * 2) - 1 + PyramidSummit; colStar++)
                    Console.Write("*");

                Console.Write("\\");

                Console.WriteLine();
            }

           
        }
        static void free_sp(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.Write(" ");
        }
        static void func_l(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                free_sp(9);
                Console.WriteLine("||||");
            }
        }
        static void f_pyramid(int a, int b, int c)
        {
            int i, j, k, l = 0;
            for (i = a; i <= b; i++)
            {
                for (j = c - l; j > a; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                {
                    if (k == 1)
                        Console.Write(" /");
                    if (k == i)
                        Console.Write(" \\");
                    else
                        Console.Write(" *");
                }
                Console.WriteLine();
                l++;
            }
        }
    }
}
