//奥特曼打小怪兽
//奥特曼血量为100，攻击力为8-12之间的一个值，命中率为80%
//小怪兽血量为100，攻击力为5-8之间的一个值，命中率为60%
//描述打架的过程，直到一方死亡为止
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int outMan_hp = 100;
            int outMan_minAtk = 8;
            int outMan_maxAtk = 12;
            int outMan_rate = 80;

            int monster_hp = 100;
            int monster_minAtk = 5;
            int monster_maxAtk = 8;
            int monster_rate = 60;

            Random dice = new Random();
            while(true) { //不知道要循环多少次，所以用while true
                Console.WriteLine("Outman starts to attack: ");
                Console.ReadKey();
                int atk = dice.Next(outMan_minAtk, outMan_maxAtk);
                int num = dice.Next(1,100);
                if (num < outMan_rate) {
                    monster_hp -= atk;
                }
                else {
                    Console.WriteLine("Outman missed!")
                }
                monster_hp -= atk;
                Console.WriteLine("Outman's attack force is :{0}, the monster still has {1} blood", atk,moster_hp);
                if (monster_hp <= 0) {
                    Console.WriteLine("Outman wins!");
                    break;
                }

                Console.WriteLine("Hit any key on your keyboard to start the monster");
                Console.ReadKey();
                atk = dice.Next(monster_minAtk, monster_maxAtk);
                outMan_hp -=atk;
                Console.WriteLine("The attack force of the monster is {0},  Outman still has {1} blood", atk, outMan_hp);
                if (outMan_hp <=0)
                {
                    Console.WriteLine("The monster wins!");
                    break;
                }

            }

              
        }
    }
}