//一维数组一个for循环就可以便利了，二维数组两个for循环
//将1到10000赋值给一个二维数组（100行100列）
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int [,] arr = new int[100,100]; //100行，100列
            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j<arr.GetLength(1); j++)
                {
                    arr[i,j] = num;
                    num++;
                    Console.WriteLine(arr[i,j]);
                }
            }
        }
    }
}