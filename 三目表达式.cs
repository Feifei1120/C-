using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            string result = age >=18? "Adult":"Non-adult"; //冒号前是True返回的结果,冒号后是False的结果
            Console.WriteLine(result);
        }
    }
}