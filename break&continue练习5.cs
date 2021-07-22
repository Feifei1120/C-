//老师问学生，这道题你会做了吗？ 如果学生答“会了(y)”，则可以放学，
//如果学生不会做(n),则老师再讲一遍，再问学生是否会做了。。。
//直到学生会了为止，才可以放学
//或老师给他讲了10遍还不会，都要放学
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            while (times <= 10) {
                Console.WriteLine("老师讲解了{0}遍，都会了吗？", times);
                string input = Console.ReadLine();
                if (input == "y") {
                    Console.WriteLine("都会了");
                    break;
                }

                times ++;
            }
            Console.WriteLine("放学");
        }
    }
}