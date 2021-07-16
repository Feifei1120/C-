//问玩家喜欢什么运动，不管玩家输入什么，你都回答：“哈哈，好巧，我也喜欢XX运动”。
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your favorite sport?");
            string sport = Console.ReadLine(); 
            Console.WriteLine("Haha, what a coincidence! I like {0}ing, too",sport);
            


        }
    }
}