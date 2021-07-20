//想控制台输出1到100之间的所有偶数
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = 0;
           while (num < 100) {
               if (num%2 == 0) {
                   Console.WriteLine(num);
               }
               num ++;
           } 
        }
    }
}