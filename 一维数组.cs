//数组和结构体很像，结构体可以存放多种数据类型，而数组只能存相同数据类型
//数组定义：数组需要初始化，什么叫初始化：声明内存空间
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int [] array = new int[2];
            array[0] = 1;
            array[1] = 1;
            array[2] = 1; //报错，下标号越界

            string [] strArray = {"123", "abc", "456"}; //长度不限
            Console.WriteLine(strArray[1]);
            Console.WriteLine(strArray.Length);

            //另外一种
            array = new int[3];
            array[0] = 1;
            for (int i = 0; i < strArray.Length; i ++)
            {
                Console.WriteLine(strArray[i]);
            }
            //数组和for循环就是天生一对
            
        }
    }
}