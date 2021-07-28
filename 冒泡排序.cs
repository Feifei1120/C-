//数组排序（bubble sort)，面试经常考，两个两个比，可以从小到大排序，也可以反过来
//作为程序员一定要会的，是一种练习for循环非常好的工具
//常见的排序有10种，本课程有4-5种
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9,3,6,4,7,2,8};
            for (int j =0; j<arr.Length-1; j++) //执行Length-1遍
            {
                for (int i = 0; i <arr.Length-1-j; i++)
                {
                    if (arr[i] > arr[i+1]) {
                        int temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;
                    }
                }
            }
            

            for (int i =0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}