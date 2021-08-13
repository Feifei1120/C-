//函数完成计算一个圆的面积和周长，并返回打印
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float r = 5.6f;
            float[] f = Circle(r);
            Console.WriteLine("周长是： {0}, 面积是: {1}",f[0],f[1]);
        }
        static float [] Circle(float radius) { //传我一个半径即可
            float[] arr = new float [2]; //为什么2，一个周长，一个面积
            arr[0] = 2*3.14f*radius;
            arr[1] = 3.14f*radius*radius;
            return arr;
        }
    }
}