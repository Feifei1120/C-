//如果你的（chinese math english)成绩满足一下任意一个条件，
//则输出“非常棒，继续加油！”
//语文成绩大于70并且数学成绩大于80并且英语成绩大于90
//语文成绩等于100或者数学成绩等于100或者英语成绩等于100
//语文成绩大于90并且其他两门中有1门成绩大于70
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Chinese grade: ");
            string chinese_ = Console.ReadLine();
            int chinese;
            Console.WriteLine("Enter your maths grade: ");
            string maths_ = Console.ReadLine();
            int math;
            Console.WriteLine ("Enter your english grade: ");
            string english_ = Console.ReadLine();
            int english;
            
            if (int.TryParse(chinese_, out chinese) && int.TryParse(maths_, out math) && int.TryParse(english_, out english)) {
                //三个数据都是符合规则的=合法的
                if((chinese > 70&&math>80&&english>90)
                    ||(chinese == 100 || math==100 || english ==100)
                    ||(chinese > 90 && (math > 70 || english > 70))){
                        Console.WriteLine("You are excelent! Keep endevoring!");
                    }
                
            }
        }
    }
}