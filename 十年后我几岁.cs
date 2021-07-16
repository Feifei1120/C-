//定义一个变量，给到你现在的年龄，输出十年后你的年龄
//练习：定义两个变量，一个存储客户的姓名，另一个存储年龄，
//然后在屏幕上显示：“aaa,bbb岁了”。aaa代表客户的姓名，bbb代表年龄
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge_this_year = 33;
            int myAge_ten_years_later = myAge_this_year+10;
            Console.WriteLine("My age after ten years is " +myAge_ten_years_later); //另一种写法 int myAge_this_year = 33;
                                                                                    //          ConsoleWriteLine("My age after ten years is " +(myAge_this_year +10))
        }
    }
}