using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(true || true && false); //一定要先算&&，再算||
        }
    }
}