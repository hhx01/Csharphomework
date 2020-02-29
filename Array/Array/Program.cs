using System;

namespace Array
{
    class Program
    {
        public void MaxMin(int[] a, out int max, out int min)
        {
            int i = 1;
            max = min = a[0];
            while (i < a.Length)
            {
                if (max <= a[i])
                {
                    max = a[i];
                }
                if (min >= a[i])
                {
                    min = a[i];
                }
                i++;
            }
        }
        public void Calculator(int[] a, out double sum, out double average)
        {
            sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            average = sum / a.Length;
        }
        static void Main(string[] args)
        {
            Program cal = new Program();
            int[] arrayNum = { 24, 224, 3, 43, 4346, 2, 42, 2, 45, 224, 222, 124 };
            int max, min;
            double average, sum;
            cal.MaxMin(arrayNum, out max, out min);
            cal.Calculator(arrayNum, out sum, out average);
            Console.WriteLine("最大值：{0};最小值：{1};和：{2};平均值：{3}", max, min, sum, average);
            Console.WriteLine("按任意键退出程序...");
            Console.ReadKey();
        }
    }
}
