using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Objects
{
    internal class TalkToChar : Object
    {
        private string scene;

        public TalkToChar(string scene, Vector2 ObjPos, char initialMark) : base(ConsoleColor.Green, ObjPos, initialMark, false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
