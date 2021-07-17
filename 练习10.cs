//今天你看学习视频花了多少时间，如果大于60分钟， 那么在控制台输出
//“今天看学习C#花了XX时间，看来你狠努力哦”
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how long you learnt C# today in minutes: ");
            string input = Console.ReadLine();
            int study_time;
            if (int.TryParse(input, out study_time)) {
            
                if (study_time >= 60) {
                    Console.WriteLine("You study very hard!");
                }
                
            }
        }
    }
}