//随机（0-100）生成1个长度为10的整数数组
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int [] arr = new int[10];
            for (int i =0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0,101);
                Console.WriteLine(arr[i]);
            }
        }
    }
}