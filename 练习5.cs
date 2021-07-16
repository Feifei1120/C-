//让用户输入一个数字，然后显示这个数字的1.5倍
//考点就是，任何用户输入的东西都是string,需要转换数据类型
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number here: ");
            string str = Console.ReadLine();
            float f = Convert.ToSingle(str);
            Console.WriteLine("The one and half times of this number is {0}", f*1.5);
        }
    }
}