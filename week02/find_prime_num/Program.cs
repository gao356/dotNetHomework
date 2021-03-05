using System;

namespace find_prime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool[] arr = new bool[101]; //若arr[index]是true代表数字index不是素数
            for (int tem = 2; tem <= 10; tem++)
            {
                if (IsPrimeNum(tem))
                {
                    int BaseNum = tem * 2;
                    while (BaseNum <= 100)
                    {
                        arr[BaseNum] = true;
                        BaseNum += tem;
                    }
                }
            }
            ShowArray(arr);
        }

        static void ShowArray(bool[] arr)
        {
            int Num = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (!arr[i])
                {
                    Console.Write(i + "\t");
                    Num++;
                } 
                if (Num % 10 == 0) Console.Write("\n");
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
