//两两比
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {22,43,12,45,32,98,54,74,54};

            for ( int j = 1; j< arr.Length; j++)
            {
                int select = arr[j]; //选第0个没有任何意义
                for (int i =j-1; i >=0; i--) //因为和前面一个数字比，所以i=j-1
                {
                    //比人家大就停止。比人家小就换位置
                    if (select < arr[i]) {
                        arr[i+1] = arr[i];
                        arr[i] = select;
                    }
                    else {
                        break;
                    }
                }
            }
            

            for (int i = 0; i <arr.Length; i ++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}