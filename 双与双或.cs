using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 10;
           Console.WriteLine(a>0 && a <20); //一旦&&前面那个可以确定结果，后面那个就不算了，效率更高
           Console.WriteLine(a>5||a<0); //直接返回true
        }
    }
}