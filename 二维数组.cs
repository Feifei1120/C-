//没有一维数组用得频繁，相当于多个等长度的一维数组排在一起
//数组定义：数组类型[,] 数组名；
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int [5];
            int[,] arr2 = new int [2,3];
            int[,] arr3 = { {1,2,3},
                            {4,5,6}}; //arr2 = arr3
            int[,] arr4 = new int[,] { {1,2,3},
                                        {4,5,6}};
                        
            Console.WriteLine(arr4.GetLength(0)); //打印行
            Console.WriteLine(arr4.GetLength(1)); //打印列

            for (int i = 0; i <arr.GetLength(0); i++) //GetLength(0)，0和1不能乱写
            {
                for (int j =0; j <arr4.GetLength(1); j++)
                {
                    Console.Write(arr4[i,j] +"\t");//也就是说二维数组用两个for循环嵌套即可
                }
                Console.WriteLine();
            }
            
        }
    }
}