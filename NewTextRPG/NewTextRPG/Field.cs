using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTextRPG
{
    public class Field
    {
        Player Player = null;
        Monster monster = null;

        public void SetPlayer(ref Player player)
        {
            Player = player;
        }

        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();

                Player.Render();
                DrawMap();

                input = int.Parse(Console.ReadLine());

                if(input == 4)
                {
                    break;
                }

                if(input <= 3)
                {
                    CreateMonster(input);
                    Fight();
                }
            }
        }

        public void Fight()
        {
            int index = 0;

            while (true)
            {
                Console.Clear();
                Player.Render();
                monster.Render();

                Console.WriteLine("1. 공격 || 2. 도망");
                index = int.Parse(Console.ReadLine());

                if(index == 1)
                {
                    
                    Player.PlayerAttack(monster.GetMonster().attack);
                    monster.SetDamage(Player.GetInfo().attack);

                    if (Player.GetInfo().hp <= 0)
                    {
                        Player.SetHP(100);
                        break;
                    }

                }

                if(index ==2 || monster.GetMonster().hp <= 0)
                {
                    monster = null;
                    break;
                }
            }
        }

        public void Create(string n, int h, int a, out Monster monster)
        {
            monster = new Monster();
            Info m = new Info();

            m.name = n;
            m.hp = h;
            m.attack = a;

            monster.SetMonster(m);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("몬스터 1", 10, 3, out monster);
                    break;
                case 2:
                    Create("몬스터 2", 40, 6, out monster);
                    break;
                case 3:
                    Create("몬스터 3", 70, 10, out monster);
                    break;
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("===========================================");
            Console.Write("");
        }
    }
}
