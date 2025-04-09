using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public class Portal : Object
    {
        private string scene;
        public Portal(string scene, Vector2 ObjPos, char initialMark) : base(ConsoleColor.Cyan, ObjPos, initialMark, false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
