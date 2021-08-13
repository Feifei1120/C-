using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 4;
            int y = 5;
            Console.WriteLine(Add(x,y));
            //函数调用规则：1.函数名要对；2.调用函数参数要对（数量，类型）；
            //3.没有返回值不能接收，有返回值可接收可不接收
        }
        static int Add(int a, int b) {
            int c = a + b;
            return c;
        }
 
     }
}