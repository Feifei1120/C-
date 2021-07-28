//交换这个数组中的第一个和最后一个、第二个和倒数第二个、以此类推；
//把数组进行反转
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7,8,9};
            for (int i =0; i <arr.Length/2; i ++) //不除以2的话，又交换回去了
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length-1-i];
                arr[arr.Length-1-i] = temp;
            }

            for (int i =0; i <arr.Length; i ++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}