//张老师的工资（salary）是由基本工资+绩效决定的
//绩效说明：
   //学生评价为A级，绩效工资500
   //学生评价为B级，不加绩效工资
   //学生评价为C级，绩效工资扣300
   //学生评价D级，绩效工资扣500
   //学生评价为E级，绩效工资扣800
   //假设张老师的工资是4000，请用户输入张老师的评级，并算出张老师的工资是多少？
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 4000;
            int performance = 0;
            Console.WriteLine("请给老师打分:");
            char c = Console.ReadKey().KeyChar;
            switch (c) {
                case "A" :
                    performance = 500;
                    break;
                case "B":
                    performance = 0;
                    break;
                case "C":
                    performance = -300;
                    break;
                case "D":
                    performance = -500;
                    break;
                case "E":
                    performance = -800;
                    break;
            }
            Console.WriteLine("张老师的工资是： " + salary + performance);
        }
    }
}
 
