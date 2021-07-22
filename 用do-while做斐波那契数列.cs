using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int index = 3;
            do {
                int num = num1+num2;
                num1 = num2;
                num2 = num;
                Console.WriteLine("第{0}数字是{1}", index, num);
                index++;
            } while (index <=20); //这里反而有个分号，while循环是没有的
        }
    }
}