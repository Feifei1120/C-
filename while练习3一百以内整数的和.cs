using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while (num < 100) {
                sum += num;
                num++;
            }
            Console.WriteLine(sum);
        }
    }
}