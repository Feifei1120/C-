using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //比如新买了一个骰子
            Random dice = new Random();
            //利用这个骰子，随机出一个数字
            int x = dice.Next(1,100);
            Console.WriteLine("x:" +x);
        }
    }
}