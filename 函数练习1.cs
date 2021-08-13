//比较两个数字的大写，返回最大值
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 10, b = 20;
            Console.WriteLine(GetMax(a,b)); //叫不叫a,b无所谓
        }
        static int GetMax(int a, int b) {
            return a > b? a:b;
        }
    }
}