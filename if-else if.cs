using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            if (age < 14)
            {
                Console.WriteLine("Child");
            }
            else if (age < 18) {
                Console.WriteLine("Teenage");
            }
            else if (age <30) {
                Console.WriteLine("Still young adult");
            }
            else if (age < 50)
            {
                Console.WriteLine("Middle-aged");
            }
            else //注意这里不需要再写条件 
            {
                Console.WriteLine("Old!");
            }
         }
    }
}