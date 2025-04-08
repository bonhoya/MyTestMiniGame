﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public abstract class Object : IInteractable
    {
        public ConsoleColor color;
        public Vector2 ObjPos;
        public char initialMark;

        public Object(ConsoleColor color, Vector2 ObjPos, char initialMark)
        {
            this.color = color;
            this.ObjPos = ObjPos;
            this.initialMark = initialMark;
        }

        public void Print()
        {
            Console.SetCursorPosition(ObjPos.x, ObjPos.y);
            Console.ForegroundColor = color;
            Console.Write(initialMark);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
    }
}
