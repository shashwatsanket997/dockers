/*
 * C# Program to Perform Matrix Multiplication
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace matrix_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = 1;
			//int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] b = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    b[i, j] = 2;
//int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] c = new int[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();
        }
    }
}
