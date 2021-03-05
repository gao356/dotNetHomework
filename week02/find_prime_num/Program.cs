using System;

namespace find_prime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfPrime = 0; //记录已经输出的素数数量
            for (int tem = 2; tem <= 100; tem++)
            {
                if (IsPrimeNum(tem))
                {
                    NumOfPrime++;
                    Console.Write(tem + "\t");
                    if (NumOfPrime % 10 == 0) Console.WriteLine();
                }
            }
        }

        static bool IsPrimeNum(int num)
        {
            bool ans = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    ans = false;
                    return ans;
                }
            }

            return ans;
        }
    }
}
