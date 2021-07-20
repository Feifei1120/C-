//找出100内所有素数（质数），只能被1和这个数字本身整除的数字
//1不是质数，最小的质数是2
//怎么判定是不是质数： 不能被3.5以内的数字整除，就是质数
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            while ( a< 100) {

                int num = a;
                int i = 2;
                bool iszhishu = true;
                while (i < num) {
                    if (num%i == 0) {
                        iszhishu = false;
                        break; //break跳出的是离他最近的循环
                    }
                    i ++;
                }
                if (iszhishu) {
                    Console.WriteLine( a+"是质数");
                }
            }
            a++;
            
            
        }
    }
}