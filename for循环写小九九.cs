//\t-->制表符的使用
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制行
            for (int i=1; i<=9; i++) {
                for (int j =1; j<=i; j++) {
                    Console.Write("{0}*{1}={2}\t",j,i,i*j);
                }
                Console.WriteLine();

            }
        }
    }
}