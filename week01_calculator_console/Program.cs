using System;

namespace week01_calculator_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入第一个数字:");
            string tem = Console.ReadLine();
            int firstNum = Int32.Parse(tem);
            Console.WriteLine("输入第二个数字:");
            tem = Console.ReadLine();
            int secondNum = Int32.Parse(tem);

            Console.WriteLine("输入运算符号:");
            char c = (char)Console.Read();

            if (c == '+') Console.WriteLine("结果是{0}",firstNum + secondNum);
            if (c == '-') Console.WriteLine("结果是{0}", firstNum - secondNum);
            if (c == '*') Console.WriteLine("结果是{0}", firstNum * secondNum);
            if (c == '/') Console.WriteLine("结果是{0}", firstNum / secondNum);
            if (c == '%') Console.WriteLine("结果是{0}", firstNum % secondNum);

        }
    }
}
