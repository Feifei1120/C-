//求二维数组（3行3列）的对角线元素的和
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] {{1,2,3},
                                     {4,5,6},
                                     {7,8,9}
                   };
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i ++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    if (i ==j || i +j ==2) { //i == j是右斜杠对角线，i+j ==2是左斜杠对角线，但是中间的5只加一次，所以结果是25，不是30
                        sum += arr[i,j];
                    }

                }
            }
            Console.WriteLine(sum);
        }
    }
}