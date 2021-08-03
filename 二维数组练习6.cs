//给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，
//将含有1的行和列全部置1
//要先便利，再置1，就是要先找到不是一的行和列，再置为1
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] arr = {{1,0,0,0,1},
                          {0,0,0,0,0,},
                          {1,0,0,0,1},
                          {0,0,0,0,1} };
        int [] row = new int [ arr.GetLength(0)];
        int [] column = new int [arr.GetLength(1)];

        for (int i =0; i<arr.GetLength(0); i++)
        {
            for (int j =0; j<arr.GetLength(1);j++)
            {
                if (arr[i,j] == 1) {
                    row [i] = 1;
                    column[j] = 1;

                }
            }
        }
        for (int i =0; i <row.Length; i ++)
        {
            Console.WriteLine(row[i]);
        }
        for (int i =0; i<column.Length; i++)
        {
            Console.WriteLine(column[i]);
        }      
        }
    }
}
