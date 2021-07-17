//提示用户输入第一个数字，然后再提示用户输入第二个数字，
//接收并计算这两个数字的和

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: ");
            string nummer_1 = Console.ReadLine();
            Console.WriteLine("Enter another number: ");
            string nummer_2 = Console.ReadLine();

            int num1;
            bool number1 = int.TryParse(nummer_1, out num1);
            int num2;
            bool number2 = int.TryParse(number_2, out num2);

            string result = number1 && number2 ? (num1+num2)+"" : "wrong enter";
            Console.WriteLine(result);
        }
    }
}