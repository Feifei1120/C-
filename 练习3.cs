//请用户输入用户名，年龄，班级，最后一起打印出来
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name,age,and class.");
            string.name =Console.ReadLine();
            int age = Console.ReadLine();
            string class_of_the_user = Console.ReadLine();
            Console.WriteLine("The user's naam is {0}, age is {1}, class is {2}",naam,age,class_of_the_user);
        }
    }
}