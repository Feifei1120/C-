//switch语句练习
//输入学生的考试成绩，如果成绩>=90：完美
//90 > 成绩 >= 80: 优秀
//80>成绩 >=70:良好
//70>成绩>=60:及格
//成绩<60,继续努力
//这道题用if很简单，但是用switch-case就略复杂
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入成绩： ");
            string str = Console.ReadLine();
            int score;
            int.TryParse(str, out score);

            score = score / 10;
            switch(score) {
                case 10 :
                    Console.WriteLine("Perfect");
                    break;
                case 9 :
                    Console.WriteLine("Perfect");
                    break;
                case 8:
                    Console.WriteLine("Excellent");
                    break;
                case 7:
                    Console.WriteLine("Good");
                    break;
                case 6:
                    Console.WriteLine("Just pass");
                    break;
                default:
                    Console.WriteLine("Keep endevoring!");
                    break;
                
            }
        }
    }
}