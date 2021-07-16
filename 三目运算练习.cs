//比较两个数的大小， 求出最大的
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 6;
           int b = 8;
           int max = a >b? a : b;
           Console.WriteLine(max); //这个逻辑可以做很多事情
        }
    }
}