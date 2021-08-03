//用得比一维数组和二维数组更少，就是多个一维数组堆在一起，而且可以长度不一样
//所以GetLength(1)没办法用
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] arr = new int [3][] {
                                new int[] {1,2,3,4},
                                new int[] {1,2,3,4,5,6},
                                new int[] {1,2,3,4,5,6,7,8,9}
                                };
            //第一种遍历方法
            for (int i =0; i<arr.GetLength(0); i++)
            {
                for (int j =0; j<arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
            Console.WriteLine();
            //第二种是foreach 的方法，老外很喜欢用，中国开发最好少用
            int[] arr2 = {1,2,3,4,5};
            foreach (int item in arr2)
            {
                foreach (int i in item)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine(); //foreach有点就是不会数组越界，缺点就是不能对迭代变量进行修改，没有for好用，for的内存好回收
            }
        }
    }
}