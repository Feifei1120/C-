//假如Unity2021年培养学员10万人，每年增长80%， 请问按此速度增长
//，到哪一年的学员人数将达到100万人？
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float unity_memeber_2021 = 100000;
            int year = 1;
            while (unity_memeber_2021 < 1000000) {
                unity_memeber_2021 = unity_memeber_2021 *(1+0.8f);
                year++;
            }
            Console.WriteLine("第{0}年，人数为{1}", year, unity_memeber_2021);



        }
    }
}