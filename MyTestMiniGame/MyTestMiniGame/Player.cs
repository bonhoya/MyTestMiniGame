using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public class Player
    {
        private Vector2 playerPos;
        private int curhp;

        public bool[,] map;

        public int CurHP { get { return curhp; } }

        private int maxhp;
        public int MaxHP { get { return maxhp; } }

        public Player()
        {
            
            maxhp = 100;
            curhp = maxhp;
        }

        public void Print()
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("P");
            Console.ResetColor();

        }

        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = playerPos;
            switch(input)
            {
                case ConsoleKey.W:
                    targetPos.y--;
                    break;
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
                case ConsoleKey.A:
                    targetPos.x--;
                    break;
                case ConsoleKey.D:
                    targetPos.x++;
                    break;
            }
            if (map[targetPos.y,targetPos.x] == true)
            {
                playerPos = targetPos;
            }
        }
    }
}
