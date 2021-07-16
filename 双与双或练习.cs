//面试经常遇到的一道题
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 10;
           Console.WriteLine(a > 0 | ++a < 20);
           int b = 10;
           Console.WriteLine(b > 0 || ++b < 20);//面试官可能会问，为什么要用双或。因为++b<20根本不用再算了，直接就是True了
           Console.WriteLine("a:" +a+ ",b" +b);//而且a=11,b还是10
        }
    }
}