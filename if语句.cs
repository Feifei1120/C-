using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your age: ");
            string str = Console.ReadLine();
            int age;
            if (int.TryParse(str, out age)) {
                if (age > 18) {
                    Console.WriteLine("You are an adult!");
                }
            }

            
        }
    }
}