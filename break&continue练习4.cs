//定义一个整型变量sum,然后分别把1-100之间的数字一次累加到sum中,
//当sum的值大于500的时候，中断操作，并在控制台输出累加到第几个数字就可以使sum大于500

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num  = 1;
            while (num < 100) {
                sum += num;
                if ( sum >500) {
                    Console.WriteLine("sum: {0}, num: {1},sum,num")
                    break;
                }
            }
        }
    }
}