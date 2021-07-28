using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {22,43,12,45,32,98,54,74,51};

            for (int j =0; j< arr.Length; j++)
            {
                int min = arr[j], index = j;
                for (int i =j; i<arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        index = i;
                    }
                } 
                int temp = arr[j];
                arr[j] = arr[index];
                arr[index] = temp;           
            }
            for(int i =0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}