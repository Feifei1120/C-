//将一个整数数组的每一个元素进行如下的处理：
//如果元素是正数则将这个位置的元素的值加1；
//如果元素是负数则将这个位置的元素的值减1，如果元素是0，则不变。
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = {-3,4,6,0,-2};
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <0)
                {
                    nums[i]--;
                }
                else if (nums[i] >0) {
                    nums[i]++;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            
            }
        }
    }
}