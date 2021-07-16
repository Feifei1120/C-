//当我们去面试的时候，前台会要求我们填一张表格，有姓名，年龄
//邮箱，家庭住址，期望工资，请把这些信息在控制台输出
//练习：定义两个变量，一个存储客户的姓名，另一个存储年龄，
//然后在屏幕上显示：“aaa,bbb岁了”。aaa代表客户的姓名，bbb代表年龄
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string intervieweeName = "James McNeil";
            int intervieweeAge = 50;
            string intervieweeEmail ="jamesmcneil71@gmail.co.uk";
            string intervieweeAdd = "Queen Elizabeth Lane 83";
            double intervieweeExpecting_Salary = 3000;
            Console.WriteLine("The info about this interviewee: "+ intervieweeName+","+ intervieweeAge + ","+intervieweeEmail+ "," +intervieweeExpecting_Salary);
        }
    }
}