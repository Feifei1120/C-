using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a + b = 20; //此处会报错，因为a,b只是被声明了，而没有被赋值，而a+b是一个表达式，赋值左边不能是表达式，重新赋值后原来的值就不存在了
        }
    }
}