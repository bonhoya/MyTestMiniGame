using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Objects
{
    public abstract class Jewel : Item
    {
        public Jewel(ConsoleColor color, Vector2 ObjPos, char initialMark) 
            : base(color, ObjPos, initialMark)
        {
            
        }

    }
}
