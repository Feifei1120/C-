//数组的英文就叫array
//从一个整数数组中找出最大值、最小值、总和、平均值
//可以使用随机数（0-100）
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int [] arr = new int[10];
            for (int i = 0; i < arr.Length; i ++)
            {
                arr[i] = r.Next(0,101);
                Console.WriteLine(arr[i]);
            }
            int max = 0, min =100, average =0, sum =0;
            for (int i =0; i <arr.Length; i++)
            {
                if (arr[i] > max) {
                    max = arr[i];
                }
                if (arr[i] < min) {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine("max:{0}, min:{1}, sum: {2}, average:{3}", max,min,sum,sum/arr.Length);
        }
    }
}