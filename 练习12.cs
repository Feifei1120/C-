//从3个数中找出最大的数， 不考虑相等
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30, b = 20, c = 40;
            if (a > b) {
                if (a >c) {
                    Console.WriteLine("a:"+a);
                }
                else
                {
                    Console.WriteLine("c:" +c);
                }
            }
            else if (b>c) 
            {
                Console.WriteLine("b:"+b);
            }
            else {
                Console.WriteLine("c:" +c);
            }
        }
    }
}