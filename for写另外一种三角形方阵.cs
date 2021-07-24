using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i<=6; i++)  {
                for (int j=1; j<=6-i; j++) {
                    Console.Write(" ");
                }
                for (int j =1; j<=2*i-1;j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i =1; i<=5; i++) {
                for(int j =1; j<=i; j++) {
                    Console.Write("");

                }
                for(int j =1; j<=2*(6-i)-1;j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}