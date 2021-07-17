using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade of Chinese here: ");
            string chinese = Console.ReadLine();
            Console.WriteLine("Please enter your grade of maths here: ");
            string maths = Console.ReadLine();
            Console.WriteLine("Please enter your grade of english here: ");
            string english = Console.ReadLine();

            int chinese_num;
            bool chinese_result = int.TryParse(chinese, out chinese_num);
            int math_num;
            bool math_result = int.TryParse(maths, out math_num);
            int english_num;
            bool english_result = int.TryParse(english, out english_num);

            string str = chinese_result && math_result && english_result ? "total grade: " +(chinese_num+math_num+english_num)+ 
            ", average grade"+ (chinese_num+math_num+english+num)/3.0f: "wrong enther";
            Console.WriteLine(str);//这个就比较安全，但是不会崩塌，不会散退
                        
        }
    }
}