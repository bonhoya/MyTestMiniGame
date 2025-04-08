using MyTestMiniGame.Scenes;
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
        private static Dictionary<string, SceneOrigin> sceneDic;
        private static void Start()
        {
            // 커서 숨기기
            Console.CursorVisible = false;

            // 게임 세팅
            gameOver = false;

            // 씬 설정
            sceneDic = new Dictionary<string, SceneOrigin>();
            sceneDic.Add("Opening", new OpeningScene());
            sceneDic.Add("MainMap", new MainMapScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Dungeon01", new Dungeon01Scene());
            sceneDic.Add("Dungeon02", new Dungeon02Scene());
            sceneDic.Add("Boss", new BossScene());
            sceneDic.Add("Ending", new EndingScene());


        }

        public static void Run()
        {
            Start();
           
            //게임 루프
            while(gameOver == false)
            {
                Console.Clear();
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
