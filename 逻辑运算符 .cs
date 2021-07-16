//与或非 &(表达式同为真-->才为真)  
//       |(两个只要任意一个为真就为真)  
//       !(取反），无论与或非哪一种，其运行结果只有两种,true/false

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           char s = "female";
           int age = 20;
           Console.WriteLine(s == "female" & age>18); //返回结果True
        }
    }
}