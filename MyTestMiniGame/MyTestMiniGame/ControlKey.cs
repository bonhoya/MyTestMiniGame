﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public class ControlKey
    {
        public Vector2 position;

        public ControlKey(Vector2 position)
        {
            this.position.x = position.x;
            this.position.y = position.y;
        }

        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;
            switch (input)
            {
                case ConsoleKey.W:
                    targetPos.y--;
                    break;
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
            }
            if (targetPos.y > 13)
            {
                targetPos.y = 11;
            }
            else if (targetPos.y < 11)
            {
                targetPos.y = 13;
            }
                position = targetPos;
        }
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">");
            Console.ResetColor();
        }

        public void Enter(ConsoleKey input)
        { 
            switch (input)
            {
                case ConsoleKey.Enter:
                    if (position.y == 11)
                    {
                        Game.ChangeScene("Home");
                    }
                    else if (position.y == 12)
                    {
                        Game.ChangeScene("");
                    }
                    else if (position.y == 13)
                    {
                        Game.GameOver();
                    }
                    break;
            }
        }
    }
}
