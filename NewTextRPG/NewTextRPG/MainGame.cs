using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTextRPG
{
    public class MainGame
    {
        public Player player = null;
        public Field Field = null;

        public void Initiliazed()
        {
            player = new Player();
            player.SelectJob();
        }

        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1. 사냥 || 2. 종료");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                    break;

                if(input == 1)
                {
                    if(Field ==null)
                    {
                        Field = new Field();
                        Field.SetPlayer(ref player);
                    }
                    Field.Progress();
                }
            }
        }

        public MainGame() { }
        ~MainGame() { } 
    }
}
