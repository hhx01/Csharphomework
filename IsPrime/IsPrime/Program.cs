using System;
using System.Collections.Generic;

namespace isPrime
{
    class Program
    {
        public void IsPrime(int a, out List<int> list)          //输入目标数字，传出结果数组
        {
            list = new List<int>();
            int nCount = 0;
            list.Add(2);
            //产生初始数组并去掉2的倍数
            for (int i = 3; i < a; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            //循环去掉所有非质数
            while (list[nCount] * list[nCount] < list[list.Count - 1])
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % list[nCount] == 0)
                    {
                        list.Remove(list[i]);
                    }
                }
                nCount++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入目标整数：");
            int num = Convert.ToInt32(Console.ReadLine());
            Program Ai = new Program();
            List<int> list = new List<int>();
            Ai.IsPrime(num, out list);
            Console.WriteLine("{0}中的所有质数为：", num);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("按任意键继续。。。");
            Console.ReadLine();
        }
    }
}
