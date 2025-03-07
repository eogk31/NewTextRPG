using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTextRPG
{
    public class Player
    {
        public Info info;

        public void SelectJob()
        {
            info = new Info();

            Console.WriteLine("직업을 선택하세요 : (1.기사 | 2.마법사 |  3.도둑)");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    info.name = "기사";
                    info.attack = 10;
                    info.hp = 30;
                    break;
                case 2:
                    info.name = "마법사";
                    info.attack = 20;
                    info.hp = 10;
                    break;
                case 3:
                    info.name = "도둑";
                    info.attack = 15;
                    info.hp = 20;
                    break;
                default:
                    Console.WriteLine("입력된 직업은 현재 미구현입니다...");
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"직업: {info.name}");
            Console.WriteLine($"공격력: {info.attack}");
            Console.WriteLine($"체력: {info.hp}");
        }

        public void PlayerAttack(int _attack)
        {
            info.hp -= _attack;
        }

        public Info GetInfo()
        {
            return info;
        }

        public void SetHP(int _hp)
        {
            info.hp = _hp;
        }


        public Player() { }
        ~Player() { } 
    }
}
