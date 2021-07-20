//用while,continue实现计算1到100（包含）之间的除了能被7整除之外所有整数的和
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            while (num <=100) {
                if (num %7 ==0) {
                    num ++;
                    continue; // 一遇到7结束本次循环,所以上面还得再num++一次，不然死循环，因为下次循环还会在遇到7
                }
                sum += num;
                num ++;

            }
        }
    }
}