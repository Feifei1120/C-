using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            short s = 12;
            short s2 = (short)(a +s); //-->强制转换有风险,精度可能有损失
            Console.WriteLine(s2); //-->一旦数字很大，马上就会有问题，所以不建议，但其实用得还是很多的
        }
    }
}