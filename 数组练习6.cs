//提醒用户输入“10|20|30|40", 将字符串用|分割输出各数字都加1，如11、21、31、41
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1|2|3|4|5";
            string[] strs = str.Split("|");
            int[] nums = new int[strs.Length];//转换成数字给他存起来
            for (int i =0; i <strs.Length; i ++)
            {
                Console.WriteLine(strs[i]);
                int.TryParse(strs[i], out nums[i]);
                nums[i]++;//加1
            }
            for (int i = 0;i <nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}