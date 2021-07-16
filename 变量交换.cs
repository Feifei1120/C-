using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 20;
            int temp = b;
            b = a;
            a = b;
            Console.WriteLine("a:" ,a + "," + "b: ",b);
        }
    }
}