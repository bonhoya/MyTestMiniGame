using MyTestMiniGame.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public static class Game
    {
        private static SceneOrigin curScene;

        private static bool gameOver;
        private static Dictionary<string, SceneOrigin> sceneDic;
        private static Player player;
        public static Player Player { get { return player; } }

        private static void Start()
        {
            // 커서 숨기기
            Console.CursorVisible = false;

            // 게임 세팅
            gameOver = false;
            player = new Player();

            // 씬 설정
            sceneDic = new Dictionary<string, SceneOrigin>();
            sceneDic.Add("Opening", new OpeningScene());
            sceneDic.Add("MainMap", new MainMapScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Dungeon01", new Dungeon01Scene());
            sceneDic.Add("Dungeon02", new Dungeon02Scene());
            sceneDic.Add("Boss", new BossScene());
            sceneDic.Add("Ending", new EndingScene());

            curScene = sceneDic["Opening"];
        }

        public static void ChangeScene(string SceneName)
        {
            curScene = sceneDic[SceneName];
        }

        public static void Run()
        {
            Start();
           
            //게임 루프
            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }

        // 게임 종료
        private static void End()
        {

        }
    }
}
