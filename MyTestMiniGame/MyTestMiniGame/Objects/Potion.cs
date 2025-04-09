using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Objects
{
    public class Potion : Item
    {
        public Potion(Vector2 ObjPos) 
            : base(ConsoleColor.DarkMagenta, ObjPos,'P')
        {
            name = "일반 포션";
            description = "체력을 30 채워준다.";
        }

        public override void Use()
        {
            Game.Player.Heal(30);
        }
    }
}
