//用户输入姓名，语文、数学、英语的成绩，最后在控制台显示：
//XXX,你的总成绩为XX分， 平均成绩为XXX分
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give your name,your point of Chinese, maths, and English");
            string name = Console.ReadLine(); 
            string Chinese = Console.ReadLine();
            string maths = onsole.ReadLine();
            string English = Console.ReadLine();
            int sum = Convert.ToInt32(Chinese) + Convert.ToInt32(maths) + Convert.ToInt32(English);
            int averagePoint = sum/3;
            Console.WriteLine("{0}'s grade is {1}, and your average grade is {2}.",name,sum, averagePoint);
        }
    }
}