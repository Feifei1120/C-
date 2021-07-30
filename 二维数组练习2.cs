//将二维数组（4行4列）的右上半部分置零
//这道题要找规律：首先发现所有的对角线都是行=列，所以，对角线右上半部分就是列大于行
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =   {{1,1,1,1},
                            {1,1,1,1},
                            {1,1,1,1},
                            {1,1,1,1}};
            for (int i =0; i <arr.GetLength(0); i++)
            {
                for (int j =0; j<arr.GetLength(1); j++)
                {
                    if (j>i) {
                        arr[i,j] =0;
                    }
                }
            }
            for (int i =0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }                   
        }
    }
}