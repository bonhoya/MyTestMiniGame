﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Objects.Jewels
{
    public class HeartJewel : Jewel
    {
        public HeartJewel(Vector2 ObjPos)
            : base(ConsoleColor.DarkBlue, ObjPos, '♥')
        {
            name = "하트 쥬얼";
            description = "어딘가에 사용하는 보석이다.";
        }

        public override void Use()
        {
            
        }
    }
}
