//提示用户输入密码， 如果密码是“888888“， 则提示正确
//否则要求再输入一次， 如果密码是 “888888”则提示正确，
//否则提示错误，程序结束。
using System;

namespace ConsoleApp2
{
    class Program //代码写得好的人，都是思路比较巧妙的
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            if (password == "888888") {
                Console.WriteLine("You have logged in.");
            }
            else {
                Console.WriteLine("Wrong password. Enter again");
                password = Console.ReadLine();
                if (password == "888888")
                {
                    Console.WriteLine("You have logged in");
                }
                else{
                    Console.WriteLine("Wrong password");
                }
            }
        }
    }
}