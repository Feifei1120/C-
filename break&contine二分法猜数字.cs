//猜数字游戏：要求用户1输入一个数字（0<=x<=100)
//游戏规则：
//a.用户只能猜10次，十次内每次根据用户输入的数据提示用户当前猜的值是太大了还是太小了，
//如果在前5次用户猜中则提示用户：“你太厉害了，你_次就猜中了。”
//b.如果用户猜中了，但是超过5次则提示用户：“不错，不错，猜对了”
//c.如果用户在最后一次猜中了则提示用户：“海底捞针啊，你真是太幸运了！”
//d.如果用户超过10次都没有猜中，则提示用户：“对不起，你已经猜了10次了，不能再猜了。”
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess_times = 1;
            int num = 57; //随机的，随便写一个1到100的数
            while (guess_times <= 10) 
            {
                Console.WriteLine("Please enter a number between 0 and 100 here: ");
                string input = Console.ReadLine();
                int i;
                int.TryParse(input,out i);
                if (i == num) {
                    if (guess_times <=5) 
                    {
                        Console.WriteLine("Excellent! You got it for {0} times, ",guess_times);
                    }

                    else if (guess_times <10) 
                    {
                        Console.WriteLine("Not bad. Bingo!");
                    }
                    else { //注意else不用写括号
                         Console.WriteLine("You are so lucky!");
                    }
                    break;
                }
                guess_times++;
                if (guess_times >10) {
                    Console.WriteLine("You do not have the chances to guess any more!");                   
                }
            }
        }
    }
}