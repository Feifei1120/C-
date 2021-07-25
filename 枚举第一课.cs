//复杂数据类型，char,bool,int,float都是简单数据类型
//一个个可以举例出来说的，并且是有限的，数量不是特别特别多，就用枚举
//大型项目用到枚举非常多
//结构体：把多种数据合成一个
//一维数组：存放相同数据类型，用得非常非常多，也非常重要
//基本数据类型是数据结构中仅有一个成员，复杂数据类型中包含多个成员,复杂数据类型也就是数据对象
//enum 枚举名，一种由一组称为枚举数列表的命名常量组成的独特类型，和switch case放在一起用会特别方便
//{
    //枚举项，
    //枚举项，
    //枚举项，
//}
//枚举类型默认可以跟int类型转换，枚举类型跟int类型是兼容的
//默认情况下，第一个枚举数的值为0，后面每个枚举数的值依次递增1
//枚举数可用初始值来重写默认值
using System;

namespace ConsoleApp2
{
    enum GenderEnum //写在类外面可以，写在类里面也可以，但是不能写在函数里面
    {
        Male,//默认就是0
        Female
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenderEnum test = GenderEnum.Male;
            if (test == GenderEnum.Male) {

            }

            switch (test)//在test后面按回车，自动生成枚举
            {
                
            }

        }
    }
}