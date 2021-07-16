//练习：定义两个变量，一个存储客户的姓名，另一个存储年龄，
//然后在屏幕上显示：“aaa,bbb岁了”。aaa代表客户的姓名，bbb代表年龄
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientName = "James McNeil";
            int clientAge = 50;
            Console.WriteLine(clientName+","+ clientAge +"years old.");
        }
    }
}