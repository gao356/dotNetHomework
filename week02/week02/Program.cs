using System;

namespace week02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("\nInput a number:");
                string _num = Console.ReadLine();
                int num = Int32.Parse(_num);

                if (num <= 0) Console.WriteLine("Input error");
                else if (num == 1) Console.WriteLine("Prime factor : " + 1);
                else
                {
                    Console.WriteLine("Prime factor : ");
                    int tem = 2;
                    while (num > 1)
                    {
                        if (num % tem == 0)
                        {
                            Console.Write(tem + "  ");
                            num /= tem;
                            tem = 2;
                        }
                        else
                        {
                            tem++;
                        }
                    }
                }
            }
        }
    }
}
