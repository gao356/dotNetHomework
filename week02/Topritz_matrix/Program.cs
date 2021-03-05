using System;

namespace Topritz_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 3;
            const int N = 4;
            int[,] matrix = new int[M, N] { { 1, 2, 3, 4 }, { 5, 3, 2, 3 }, { 9, 5, 1, 2 } };
            bool ans = true;

            int KeyNum = matrix[0, 0];
            for (int i = 2; i <= min(M, N); i++) 
            {
                if (matrix[i - 1, i - 1] != KeyNum)
                {
                    ans = false;
                    break;
                }
            }

            if (ans) Console.WriteLine("It is a Toptriz matrix.");
            else Console.WriteLine("It is not a Toptriz matrix.");
        }

        static int min(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }
    }
}
