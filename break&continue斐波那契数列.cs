//1,1,2,3,5,8,13...第20位数字是多少
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
            while(index<=20) {
                int num = num1+num2;
                num1 = num2;
                num2 = num;
                Console.WriteLine("第{0}数是{1},index,num");
                index++;
            }
        }
    }
}