using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One Person!");
            //console: 控制台，控制台其实也是一个程序
            
            string name = Console.ReadLine(); //读一行，将读一行的内容存在name这个位置
            Console.WriteLine(name); //将上一句代码存在name的值打印出来

            //Console.ReadLine(); 让程序不结束，卡在这里，这个方法之后会经常用
        }
    }
}