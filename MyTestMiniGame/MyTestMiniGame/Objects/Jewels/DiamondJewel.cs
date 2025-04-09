using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Objects.Jewels
{
    public class DiamondJewel : Jewel
    {
        public DiamondJewel(Vector2 ObjPos)
            : base(ConsoleColor.DarkYellow, ObjPos, '◆')
        {
            name = "다이아몬드 쥬얼";
            description = "어딘가에 사용하는 보석이다.";
        }

        public override void Use()
        {
            Console.WriteLine("이 아이템은 사용할 수 없습니다.");
        }
    }
}
