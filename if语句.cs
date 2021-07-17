using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string result = input == "123" ? "yes":"no";
            Console.WriteLine(result);//以上是第一种用法

            if(input == "123") {
                Console.WriteLine("yes");
            }//第二种方法用if
            
        }
    }
}