//函数也可以叫方法
//其实第一节课就用到了函数。Console.WriteLine就是一个函数，参数就是hello world
//带有小括号的一般都是函数，函数首单词首字母大写，变量是首单词首字母小写，后面每个单词首字母大写
//static表示静态,void表示没有返回类型，Main是起源，是开始
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //是注释，不参与编译，每一行要以分号结尾
            //代码就是要与用户交互信息
        }
        //括号里的叫参数，也可以没有
        //但是函数有一个非常明显的特征：不调用，不执行
        static void Test() {
            Console.WriteLine("Test"); //最简单的函数，当想输出Test，就可以调用这个函数
        }
    }
}