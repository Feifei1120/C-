//6.9节，题目不方便描述，但是可以想象成x,y轴
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello"); //控制台颜色修改
            Console.SetCursorPosition(5,5);
            Console.WriteLine("world"); //控制台控制光标，竖向的一个单位等于横向的两个单位
            Console.SetCursorPosition(5,5);
            Console.Write("world"); //截止到这里与这道题目无关，只是先了解一下相关知识
            int x = 0, y = 0;

            while(true) {
                
                Console.SetCursorPosition(0,0);
                for (int i=0; i <2; i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.SetCursorPosition(5,5);
            Console.ForegroundColor = ConsoleColor.Gray;
            

            //按键已经接收到，但是不会显示在控制台
            char input = Console.ReadKey(true).KeyChar;
                switch(input) {
                    case 'a':
                    case 'A': //一定单引号
                        x -=1;
                        if (x <= 0) {
                            x = 0;
                        }
                        break;
                    case 'd':
                    case 'D':
                        x += 1;
                        if (x >3)
                        {
                            x =3;
                        }
                        break;
                    case 'w':
                    case 'W':
                        y -=1;
                        if (y <= 0)
                        {
                            y = 0;
                        }
                        break;
                    case 's':
                    case 'S':
                        y += 1;
                        if (y>1)
                        {
                            y = 1;
                        }
                        break;

                }
            }
        }
    }
}