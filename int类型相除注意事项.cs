using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            a = 3;
            b = 2;
            Console.WriteLine("a/b"); //按理说应该是1.5，但是由于a和b都是int类型，所以output是1，结果也只会显示int类型
            
    }
}