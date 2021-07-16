using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           bool gameOver;
           bool isWin;
           int health = 100;
           gameOver = true;
           isWin = false;
           print( gameOver || isWin && health > 0); //health>0是优先运算，true
        }
    }
}