//编写一个程序接受用户输入的字符。如果输入的字符是0-9数字中的一个，
//则显示“您输入了一个数字”，否则显示”这不是一个数字“
//这道题用ASCII做
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a stirng: ");
            char x = Console.ReadKey().KeyChar; //目的：接收字符
            if(x >=48 && x <=57)
            {
                Console.WriteLine("x is a number");
            }
            else {
                Console.WriteLine("X is not a number");
            }
        }
    }
}