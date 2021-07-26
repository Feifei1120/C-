//复杂数据类型用惯了，再用简单数据类型甚至都不习惯
//定义QQ状态的枚举，Qme,OnLine,OffLine,Leave,Busy提示用户选择一个在线状态，
//用变量接受，并将用户的输入转换成枚举类型，并输出当前状态是否能接受消息。
using System;

namespace ConsoleApp2
{
    class Program
    {
        enum QQState //写在类里面也可以
        {
            Qme,
            Online,
            Offline,
            Leave,
            Busy,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your state:0.Chat with me,1.I am online,2.I am not online,3.Leaving,4.Busy");
            string input = Console.ReadLine();
            int num;
            if (int.TryParse(input,out num)) {
                if (num >=0 && num <=4) {
                    QQState state = (QQState)num;
                    //Console.WriteLine(state);测试
                    switch (state) 
                    {
                        case QQState.Qme:
                            Console.WriteLine("Qme,accept the message");
                            break;
                        case QQState.Online:
                            Console.WriteLine("Online,accept the message");
                            break;
                        case QQState.Offline:
                            Console.WriteLine("I am offline");
                            break;
                        case QQState.Leave:
                            Console.WriteLine("Absent");
                            break;
                        case QQState.Busy:
                            Console.WriteLine("Busy");
                            break;
                        default:
                            break; //所以就很方便，不然要写很多if
                    }
                }
            }


    }
}