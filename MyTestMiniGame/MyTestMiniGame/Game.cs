using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public class Game
    {
        private static SceneOrigin sceneOrigin;

        private static bool gameOver = false;
        private static void Start()
        {

        }

        public static void Run()
        {
            Start();
           
            //게임 루프
            while(gameOver == false)
            {
                sceneOrigin.Render();
                sceneOrigin.Input();
                sceneOrigin.Update();
                sceneOrigin.Result();

            }

        }

        // 게임 종료
        private static void End()
        {

        }
    }
}
