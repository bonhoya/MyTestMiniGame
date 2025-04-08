using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public abstract class SceneOrigin
    {
        public abstract void Render();
        public abstract void Input();

        public abstract void Update();

        public abstract void Result();

    }
}
