//用结构体描述颜色（r，g，b，a）
using System;

namespace ConsoleApp2
{
    struct Rectangular
    {
        public double length;
        public double width;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Zhangsan = new Person ();
            Zhangsan.name = "张三";
            Zhangsan.age = 18;
            Zhangsan.gender = "male";
        }
    }
}