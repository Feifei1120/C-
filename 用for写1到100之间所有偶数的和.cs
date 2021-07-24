using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i =1; i<=100; i +=2) {
                sum = sum +i;
                
            }
            Console.WriteLine("1到100之间的偶数的和为:" + sum);
        }
    }
}