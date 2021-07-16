using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2008;
            bool b1 = year%400 == 0;
            bool b2 = (year %4 == 0) && (year%100 !=0);
            Console.WriteLine(b1 || b2 ?"闰年":"平年");
        }
    }
}