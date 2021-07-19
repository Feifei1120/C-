//提示用户输入年龄，如果大于等于18，则告知用户是成年，可以学习高级课程，如果
//小于13岁，则告知是儿童，学低阶课程，如果大于等于13岁并且小于18，
//则提示是青少年，如果需要学习告诫课程输入（yes，no），如果输入的是yes
//则提示用户请查看，否则提示“退出”，你放弃查看
//题目的坑：注意理清题目的顺序
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 12;
            if (age<13) {
                Console.WriteLine("是儿童，学低阶课程");
            }
            else if (age < 18) {
                Console.WriteLine("青少年，确认学习输入yes，退出输入no");
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.WriteLine("开始学习");
                }
                else{
                    Console.WriteLine("结束");
                }
            }
            else {
                Console.WriteLine("是成年人，可以学习高阶课程");
            }
        }
    }
}