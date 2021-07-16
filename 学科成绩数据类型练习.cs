using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "张三";
            int maths = 90;
            int Chinese = 80;
            int English= 70;
            Console.WriteLine(name + "的数学成绩是： " + maths);
            Console.WriteLine(name + "的语文成绩是： " + Chinese);
            Console.WriteLine(name + "的英语成绩是" + English); //这里的加号就是连字符，而不是做加法运算

        }
    }
}