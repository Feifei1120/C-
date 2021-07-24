using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1; i <=10; i++) {
                for(int j=1; j<=10-i; j++) {//控制列的空格数
                    Console.Write("");

                }
                //控制列的星星数
                for (int j =1; j <=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}