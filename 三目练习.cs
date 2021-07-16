//让用户输入一个用户名，如果不是老王，就全部都是流氓
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = Console.ReadLine();
           string result = name == "老王" ? "老王":"流氓"; 
           System.Console.WriteLine(result);
        }
    }
}