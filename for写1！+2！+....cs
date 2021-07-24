//求阶乘，阶乘就是从1开始乘到自己
//把一个问题切分成多个问题，一个一个解决
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int num=1;num<=10;num++) {
                int multiply = 1;
                for (int i = 1; i <= num; i++)
                {
                    multiply *= i;
                }
                Console.WriteLine(num+"multiply:" + multiply);
                sum += multiply;
            
            }
            Console.WriteLine("sum:" +sum);
        }
    }
}