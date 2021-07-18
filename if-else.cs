//练习：输出结果是多少，这是一个带坑的练习
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver;
            int money;
            int day = 0;
            gameOver = true;
            money = 40;
            if (gameOver) {
                if (money>50){
                    day = 1;
                }
            }   else  //这个else根本不会执行，因为它与之对齐的是第二个if
            {
                day = 2;
                money = 50;
            }
            Console.WriteLine("day =" + day+ "; money = " + money);//所以if条件不成立，而else又没有被执行，所以day还是0，money还是40
        }
    }
}