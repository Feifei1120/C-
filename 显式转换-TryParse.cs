//int x;
//int.TryParse(string, out x);-->转换成功，才会赋值给x

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a data: ");
            string input = Console.ReadLine();
            int num;
            bool b = int.TryParse(input, out num); //-->output:True
            string result = b ? "Yes,data is a number":"Wrong enter!"
            Console.WriteLine("b:{0}),num:{1}, the result of enter: {2}",b,num,result);
        }
    }
}