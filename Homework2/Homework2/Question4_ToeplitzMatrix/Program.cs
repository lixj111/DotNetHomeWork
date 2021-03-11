using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True

namespace Question4ToeplitzMatrix
{
    class Program
    {
        public static bool isToeplitzMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for(int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i + 1, j + 1] != matrix[i, j])
                        return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("请依次输入矩阵的行数M和列数N：");
            int M = Int32.Parse(Console.ReadLine());
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请依次输入该矩阵的元素值：");
            int[,] matrix = new int[M, N];
            for (int a = 0; a < M; a++)
                {
                    char[] s = new char[] { ' ' };
                    string[] mat = Console.ReadLine().Split(s);
                    int[] matrix1 = new int[N];
                    matrix1 = Array.ConvertAll<string, int>(mat, m => Int32.Parse(m));
                    for (int b = 0; b < N; b++)
                    {
                        matrix[a, b] = matrix1[b];
                    }                   
                }
            var result = isToeplitzMatrix(matrix);
            Console.WriteLine(result);
            Console.WriteLine("输入0结束程序： ");
            string endth = Console.ReadLine();
        }
    }
}
