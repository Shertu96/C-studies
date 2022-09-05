// Вычисление функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

namespace HW68
{
    class Program
    {
        static void Main()
        {
            int M = 4;
            int N = 0;

            Console.WriteLine(A(M, N));
        }

        static int A(int M, int N)
        {
            if (M == 0)
            {
                return N + 1;
            }
            if (M > 0 && N == 0)
            {
                return A(M - 1, 1);
            }
            // M > 0 && N > 0
            return A(M - 1, A(M, N - 1));
        }
    }
}
