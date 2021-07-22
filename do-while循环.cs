//无条件进入do循环体，满足do条件，不满足才进入while循环
//要求用户输入用户名和密码，只要不是admin,888888就一直提示用户名或密码，请重新输入
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            do {
                Console.WriteLine("Please enter your user name:");
                string username = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string password = Console.ReadLine();

                if (username == "admin" && password == "888888")
                {
                    Console.WriteLine("You are inlogged!");
                    break;
                }
            }while (true);
        }
    }
}