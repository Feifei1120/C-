//一个变量存储客户的姓名，然后在屏幕上显示：“你好，XXX”。 XXX代表客户的姓名
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string client_name = "Dean Wright";
            Console.WriteLine("Hello," + client_name);
        }
    }
}
