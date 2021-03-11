using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//输出用户指定数据的所有素数因子

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Console.Write("Please input an int positive number:");   //用户输入指定数据
            s = Console.ReadLine();
            n = Int32.Parse(s);

            int a = 2;
            if (n == 2)
                Console.WriteLine(n);
            while (n > 2 & a <= n)
            {
                if (n % a == 0)                    //判断a是否是n的因子
                {
                    int b = 1;
                    for (int i = 2; i < a; i++)    //判断a是否为素数
                    {
                        if (a % i == 0)
                        {
                            b = 0; 
                        }
                    }
                    if (b == 1)
                        Console.WriteLine(a);
                }
                a=a+1;  
            }
            Console.WriteLine("输入0结束程序： ");
            string endth = Console.ReadLine();
        }
    }
}
