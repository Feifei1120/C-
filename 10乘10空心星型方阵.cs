using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i<=10; i++) {
                if ( i ==1 || i ==10) 
                {//第一行和第十行打印内容
                    for (int j =1; j<=10; j++) {
                        Console.WriteLine("*");
                    }
                }
                else {
                    //第二行到第九行打印内容
                    for(int k =1; k <=10; k++) {
                        if (k ==1 || k == 10) 
                        {//第二行到第九行 第一列和第十列打印*
                            Console.Write("*");
                        }
                        else 
                        {//第二行到第九行 第二列到第九列打印空格
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
            }
    }
}