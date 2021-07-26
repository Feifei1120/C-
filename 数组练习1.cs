//创建一个数组A，值与下标号一样
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[10];
            for (int i =0; i <= a.Length; i++)
            {
                a[i] = i;
            }
            Console.WriteLine(a[5]);
        }
    }
}