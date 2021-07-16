//要求用户输入一个年份，然后判断是不是闰年
//闰年判断:1.年份能被400整除
//2.年份能被4整除，但是不能被100整除

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Console.ReadLine();
            bool result = year%400 == 0 && year % 4 ==0 && year%100 != 0  ? "是闰年":"非闰年";
            System.Console(result);
        }
    }
}