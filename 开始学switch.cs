using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "A";
            switch(str) { //switch 相当于一个开关
                case "A":
                    {
                        Console.WriteLine("输出的是A");
                    }
                    break;
                case "B":
                    {
                        Console.WriteLine("输出的是B");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("非AB")
                    }
                    break;

            }

            //以上代买用if-else也完全一模一样
            if (str == "A")
            {
                Console.WriteLine("输出的是A");
            }
            else if (str == "B")
            {
                Console.WriteLine("输出的是B");
            }
            else 
            {
                Console.WriteLine("非AB");
            }
        }
    }
}