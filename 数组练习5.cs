//将数组用| 分割输出，如10|108|95|5 string.split
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1;2;3;4;5"; //换成竖杠也可以，别的也行
            string[] strs = str.Split(";");
            for (int i =0; i <strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }
    }
}