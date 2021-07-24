using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制行
            for(int i=1; i <=10; i++) {
                for(int j = 1; j<=i; j++) { //j是控制列的
                    Console.Write("*");
                }
                Console.WriteLine();//每一行结束后换行

            }
        }
    }
}