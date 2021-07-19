//输入一个整数，如果这个数是个偶数，则打印“Your input is even"
//否则打印“your input is odd"
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer here: ");
            string input = Console.ReadLine();
            int num;
            if (int.TryParse(input, out num))
            {
                if (number%2 == 0) 
                {
                Console.WriteLine("Your input is even");
                }
                else {
                    Console.WriteLine("Your input is odd");
                }
            }
        }
        
    }
}