//结构体是一种自定义复合数据类型，可以帮我们一次性声明多个不同类型的变量，
//当然多个相同数据类型的变量也可以；声明变量时不能赋初始值；
//当结构的成员为Public时，我们可以通过结构的对象。成员名来访问；
//struct 结构名
//{
    成员;
    成员;
    成员;

//}
using System;

namespace ConsoleApp2
{
    struct Person
    {
        public string name;//不能赋初始值
        public int age;
        public char gender;

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