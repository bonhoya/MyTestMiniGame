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
            if (Game.Player.inventory.items.Any(item => item.name == "스페이드 쥬얼")
                        && Game.Player.inventory.items.Any(item => item.name == "하트 쥬얼")
                        && Game.Player.inventory.items.Any(item => item.name == "클로버 쥬얼"))
            {
                Console.WriteLine("시스템: 모든 쥬얼에서 빛이 발생합니다...!!!");
                Console.ReadKey(true);
                Game.Player.GameScore = 4;
                Game.Player.inventory.Stack.Pop();
                Game.Player.inventory.Stack.Pop();
                Game.Player.inventory.Stack.Pop();
                Game.GameClear();
            }
            else
            {
                Console.WriteLine("시스템: 이 아이템은 사용할 수 없습니다.");
                Console.WriteLine("시스템: 하지만, 다른 쥬얼을 다 모으고");
                Console.WriteLine("다이아몬드 쥬얼을 사용한다면??");
            }
        }
    }
}
