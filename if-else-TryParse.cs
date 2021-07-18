using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            string strA = Console.ReadLine();
            Console.WriteLine("Enter b: ");
            string strB = Console.ReadLine();

            int a,b; //同时声明a与b
            if (int.TryParse(strA, out a) && int.TryParse(strB, out b)) {
                if ((a%b == 0) || (b%a == 0) || (a +b > 100))
                {
                    Console.WriteLine("a:" +a);
                }
                else {
                    Console.WriteLine("b:"+b);
                }
                
            }
        }
    }
}