using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string str = "123a";
            int i = Convert.ToInt32(); //代码将卡死在这里，后面代码将无法继续执行
            Console.WriteLine("数据是： ", i);
            }
            catch (Exception e)  {
                Console.WriteLine(e);
            }
            Console.WriteLine("Test");//有了try catch,代码就不会卡死
        }
    }
}