using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和

namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IArray;  
            Console.WriteLine("请输入整数数组的元素个数：");
            int length = Convert.ToInt32(Console.ReadLine());
            IArray = new int[length];           
            for (int i = 0; i < length; i++)
            {
                Console.Write("请输入第{0}个数组的值：",i);
                IArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = IArray[0];
            int min = IArray[0];
            int ave = 0;
            int sum = IArray[0];

            for (int i = 1; i < length; i++) //求一个整数数组的最大值、最小值、平均值和所有数组元素的和
            {
                if (max < IArray[i])
                    max = IArray[i];
                if (min > IArray[i])
                    min = IArray[i];
                sum = sum + IArray[i];
            }
            ave = sum / length;
            Console.WriteLine($"最大值为：{max},最小值为：{min},平均值为：{ave}，所有元素之和为：{sum}");
            Console.WriteLine("输入0结束程序： ");
            string endth = Console.ReadLine();
        }
    }
}
