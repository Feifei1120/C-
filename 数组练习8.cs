//定义一个有10个元素的数组，使用for循环语句，从键盘上输入10名同学的数学成绩，将成绩依次存入数组，
//然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your classmates' grades, use de comma to split each grade");
            string input = Console.ReadLine();
            string[] strs = input.Split(",");
            int [] grades = new int[strs.Length];
            for (int i =0; i <grades.Length; i ++)
            {
                int.TryParse(strs[i], out grades[i]);
            }

            int max=0, min=100, sum=0;
            for (int i =0; i < grades.Length; i++)
            {
                if (grades[i] > max) {
                    max = grades[i];
                }
                if (grades[i] < min) {
                    min = grades[i];
                }
                sum += grades[i];
            }
            Console.WriteLine("max:{0}, min:{1}, sum: {2},ave:{3}", sum/grades.Length);
        }
    }
}