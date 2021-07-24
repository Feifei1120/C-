//水仙花数：eg：153 = 1*1*1 +5*5*5 +3*3*3
//水仙花数：个位，十位，百位，每个位数的数字的立方相加等于这个数字本身  
//思路：先求一个数的个，十，百位
//Rua语言和C#很像，但是Rua只是协助性的语言，热更新语言，游戏项目会把Rua当插件来用
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int num = 100; num<=999;num++) {}
                int num = 153;
                int hundred = num/100; //小数部分直接去掉了，所以不用担心小数
                int dozen = num/10%10;
                int rest = num%10;//以上就可以把个十百位全求出来
                if(num ==hundred*hundred*hundred+dozen*dozen*dozen+rest*rest*rest) {
                    Console.WriteLine("{0}, {1}, {2}", hundred,dozen,rest); 
                }             
            }
        }
    }
}