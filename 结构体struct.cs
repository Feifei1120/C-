//访问权限：供外部使用的是public,私有的是private,protect在继承里会学
//练习：用结构体描述一个学生的信息（姓名，性别，年龄，专业）

using System;

namespace ConsoleApp2
{
    struct Student
    {
        public string name;
        public char gender;
        public int age;
        public string major;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student wangwu = new Student();
            wangwu.name = "王五";
        }
    }
}