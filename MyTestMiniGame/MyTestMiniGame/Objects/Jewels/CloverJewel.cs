using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyTestMiniGame.Objects.Jewels
{
    public class CloverJewel : Jewel
    {
        public CloverJewel(Vector2 ObjPos)
            : base(ConsoleColor.DarkGreen, ObjPos, '◆')
        {
            name = "클로버 쥬얼";
            description = "어딘가에 사용하는 보석이다.";
        }

        public override void Use()
        {

        }
    }
}
