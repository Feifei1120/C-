using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "12345";
            string str2 = "456";
            int i = int.Parse(str);
            int i2 = int.Parse(str2);
            Console.WriteLine(i+i2); //-->这种方法和convert没有什么区别
            
        }
    }
}