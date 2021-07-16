using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(223/4.0f); //有.0f-->隐式转换，把它变成有小数的输出，不然输出的就是一个int
        }
    }
}