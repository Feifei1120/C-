//用结构体描述二维坐标的位置（x，y）
//用结构体描述三维坐标的位置（x,y,z)
//用结构体描述颜色（r,g,b,a)
//用结构体描述一个矩形
using System;

namespace ConsoleApp2
{
    struct Vector2
    {
        public double x,y;
    }
    struct Vector3
    {
        public Vector2 vector2;
        public double z;
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}