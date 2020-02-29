using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0;
            bool flag = true;
            try
            {
                Console.WriteLine("请输入第一个数字：");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入第二个数字：");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入需要做的运算：");

                switch (Console.ReadLine())
                {
                    case "+":
                        num3 = num1 + num2;
                        break;
                    case "-":
                        num3 = num1 - num2;
                        break;
                    case "*":
                        num3 = num1 * num2;
                        break;
                    case "/":
                        if (num2 - 0 == 0)
                        {
                            Console.WriteLine("除数不能为0！！！");
                        }
                        else
                            num3 = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("请输入正确运算符号~~~");
                        flag = false;
                        break;
                }

                if (flag)
                {
                    Console.WriteLine("计算结果为：{0}", num3);
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("请输入一个数字!!!（当前输入为字母）");
            }
            Console.Write("按任意键退出程序...");
            Console.ReadKey();
        }
    }
}