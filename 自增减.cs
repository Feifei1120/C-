//++,--
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(++a); //相当于python 里的a = a+1
            Console.WriteLine(a++); //此时a还是10，没有任何改变，因为++在后面，所以是先使用，或者说先输出，后操作增减，截止目前增减还没有被执行，在下一行代码才被执行
            Console.WriteLine(a); //此时a已经变成11，因为前面有a++的自增，所以a被重新赋值了

            int e = 50;
            e++;
            Console.WriteLine(e);

            int b = 12;
            b++; //b变成13
            b = b+b; 
            Console.WriteLine(b);
        }
    }
}
