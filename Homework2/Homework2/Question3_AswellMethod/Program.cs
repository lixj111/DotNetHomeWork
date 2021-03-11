using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//用“埃氏筛法”求2~ 100以内的素数

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] Array;
            Array = new int[100];
            for (int i = 0; i < Array.Length; i++)          //将2~100依次赋值给数组[2]~[100]
            {
                Array[i] = i; 
            }

            for (int i = 2; i < Array.Length; i++)          //将2的倍数、3的倍数、4的倍数……对应的数组元素置为0
            {
                for(int j = 2*i;j < Array.Length; j+=i)
                {
                    Array[j] = 0;
                }
            }

            for(int i=2;i<Array.Length;i++)                 //输出未被置零的数组元素的值
            {
                if (Array[i] != 0)
                    Console.WriteLine("{0}",Array[i]);
            }
            Console.WriteLine("输入0结束程序： ");
            string endth = Console.ReadLine();
        }
    }
}
