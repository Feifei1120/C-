using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            short sh = 3;
            int i = 10;
            int i2 = i +sh; //隐式类型转换，把sh转成int
            System.Console.WriteLine(i2);
        }
    }
}