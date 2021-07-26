//创建一个数组A，值与下标号一样
//创建另一个数组B,将数组A中每个元素的值乘以2存入数组B
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

            int[] b = new int[a.Length];
            for (int i = 0; i < b.Length; i ++)
            {
                b[i] = a[i] *2;
            }
            Console.WriteLine(b[5]);
        }
    }
}