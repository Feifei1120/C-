//break通常用在switch语句和循环语句中。可使程序跳出switch语句和终止循环
//continue跳过循环体中剩余的语句而强行执行下一次循环。立即结束本次循环
//判断循环条件，如果成立，则进入下一次循环，否则退出循环
//continue
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num <10) {
                num ++;
                Console.WriteLine("num:" + num);
                if (num == 3) {
                    break;
                }
            }
         }
    }
}