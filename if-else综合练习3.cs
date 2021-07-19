//输入年龄，如果年龄在10-18或者25-30范围内，输出“可以访问”，否则，输出“拒绝访问”
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            string input = Console.ReadLine();
            int age;
            if (int.TryParse(input, out age))
            {
                if ((age>10 && age <18)|| (age>25&&age<30))
                {
                    Console.WriteLine("You can access.");
                }
                else {
                    Console.WriteLine("Access refused!");
                }
            }
        }
    }
}