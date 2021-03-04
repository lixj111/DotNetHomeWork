using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double x = 0;
            double y = 0;
            Console.Write("Please input a double number x:");
            s = Console.ReadLine();
            x = Double.Parse(s);
            Console.Write("Please input a double number y:");
            s = Console.ReadLine();
            y = Double.Parse(s);
            Console.Write("Please input an operator to calculate x and y:");
            s = Console.ReadLine();
            Console.Write("x:{0},s:{1},y:{2},结果为:", x, s, y);
            if (s == "+")
                Console.WriteLine(x+y);
            else if (s == "-")
                Console.WriteLine(x-y);
            else if (s == "*")
                Console.WriteLine(x*y);
            else if (s == "/")
                Console.WriteLine(x/y);
            else
                Console.WriteLine("Error.");
        }
    }
}
