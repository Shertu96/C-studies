// Задать значения M и N. Находить сумму натуральных элементов в промежутке от M до N.

using System;

namespace HW66
{
    class Program
    {
        static void Main()
        {
            int M = 4;
            int N = 8;

            Console.WriteLine(Matrix(M, N)); // Вывод для упрощения проверки работы алгоритма
            Console.WriteLine(Sum(M, N));
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

        static int Sum(int M, int N)
        {
            int sum = 0;
            for (int i = M; i <= N; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
