//枚举转换成int,int转换成枚举
//枚举类型默认跟int类型相互兼容，可以通过强制类型转换；
//枚举转换成字符串 myEnum.ToSring();但是这个用得非常少
//字符串转换成枚举 （要转换的枚举类型） Enum.Parse(typeof(要转换的枚举类型))，“要转换的字符串”）；
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
            //把字符串转换成枚举
            QQState state = QQState.Leave;
            state = (QQState)Enum.Parse(typeof(QQState), "Busy");
            Console.WriteLine(state);
        }
    }
}