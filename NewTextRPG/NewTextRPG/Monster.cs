using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTextRPG
{
    public class Monster
    {
        public Info monster;

        public void SetDamage(int _attack)
        {
            monster.hp -= _attack;
        }

        public void SetMonster(Info Monster)
        {
            monster = Monster;
        }

        public Info GetMonster()
        {
            return monster;
        }

        public void Render()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"이름: {monster.name}");
            Console.WriteLine($"공격력: {monster.attack}");
            Console.WriteLine($"체력: {monster.hp}");
        }

        public Monster() { }
        ~Monster() { }
    }
}
