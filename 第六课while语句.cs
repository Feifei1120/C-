//计算机最喜欢重复，做重复的事情，计算机特别快，比如百万次也就几分钟
 using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a > 0) {
                Console.WriteLine("a:" +a);
            }
            
            int b = 10;
            while (b > 0) {
                Console.WriteLine("b:" +b);
                b --;  //b-1,一直减1，剪刀0停止运行while
            }
         }
    }
}