using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Objects
{
    public abstract class Item : Object
    {
        public string name;
        public string description;

        public Item(Vector2 ObjPos, char initialMark) 
            : base(ConsoleColor.Yellow, ObjPos, initialMark, true)
        {

        }


        public override void Interact(Player player)
        {
            player.inventory.Add(this);
        }

        public abstract void Use();
    }
}
