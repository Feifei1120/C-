//特别重要，用得比while还多
//for(初始表达式(1)；循环表达式(2)，增量表达式(4))
//{
    //循环体(3)
//}
//注意一次为1,2,3,4
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =0; i<10; i++ ) {
                Console.WriteLine("I love Python!"); //只是和while位置变换不一样而已
            }
        }
    }
}