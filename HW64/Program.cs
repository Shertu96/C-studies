// Задать значения M и N. Программа выведет все натуральные числа в промежутке от M до N.
using System;

namespace HW64
{
    class Program
    {
        static void Main()
        {
            int M = 1;
            int N = 10;

            Console.WriteLine(Matrix(M, N));
        }

        static string Matrix(int M, int N)
        {
            string final = String.Empty;

            for (int i = M; i < N; i++)
            {
                final += i + ", ";
            }
            return final + N;
        }
    }
}
