//依次输入学生的姓名， c#语言的成绩，Unity的成绩， 两门成绩都大于等于90分
//才能通过，请输出最后的结果
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           string.name = Console.ReadLine();
           int.cShape_mark = Console.ReadLine();
           int.unityMark = Console.ReadLine();
           string result = cSharp_mark >=90 && unityMark >=90 ? "pass":"fail";//把逻辑运算与三目结合起来
           System.Console.WriteLine(result);
           
        }
    }
}