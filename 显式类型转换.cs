using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "2.3";
            float f = Convert.ToSingle(s); //single和double配对，为什么float是single-->单精度类型
            Console.WriteLine(f);
        }
    }
}