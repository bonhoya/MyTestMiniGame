using MyTestMiniGame.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private static ControlKey controlKey;
        public static ControlKey ControlKey { get { return controlKey; } }

        public static string preSceneName;

        private static void Start()
        {
            // 커서 숨기기
            Console.CursorVisible = false;

            // 게임 세팅
            gameOver = false;
            player = new Player();
            Console.SetWindowSize(33, 40);
            
            // ControlKey 세팅
            controlKey = new ControlKey(new Vector2(11, 15));

            // 씬 설정
            sceneDic = new Dictionary<string, SceneOrigin>();
            sceneDic.Add("Opening", new OpeningScene());
            sceneDic.Add("MainMap", new MainMapScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("Dungeon", new DungeonScene());
            sceneDic.Add("DungeonQuiz", new DungeonQuizScene());
            sceneDic.Add("QuizFail", new QuizFailScene());
            sceneDic.Add("Maze", new MazeScene());
            sceneDic.Add("Boss", new BossScene());
            sceneDic.Add("Ending", new EndingScene());
            sceneDic.Add("HomeTown", new HomeTownScene());
            sceneDic.Add("Shop", new ShopScene());
            sceneDic.Add("Shopper", new ShopperScene());

            curScene = sceneDic["Opening"];
        }

        public static void ChangeScene(string SceneName)
        {
            preSceneName = curScene.name;
            curScene = sceneDic[SceneName];
            curScene.Enter();
        }

        public static void Run()
        {
            Start();
            

            //게임 루프
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
            }

            End();
        }

        // 게임 종료
        private static void End()
        {
            if(Game.Player.GameScore == 1)
            {
                Console.WriteLine("엔딩 1: 퀴즈를 틀린자");
            }

        }

        public static void GameOver()
        {
            Console.SetWindowSize(33, 40);
            gameOver = true;
            Console.Clear();
            Console.WriteLine("┌───────────────────────────────┐");
            Console.WriteLine("│   _____                       │");
            Console.WriteLine("│  / ____|                      │");
            Console.WriteLine("│ | |  __  __ _ _ __ ____  ___  │");
            Console.WriteLine("│ | | |_ |/ _` | '_ ` _  \\/ _ \\ │");
            Console.WriteLine("│ | |__| | (_| | | | | | |  __/ │");
            Console.WriteLine("│  \\_____|\\__,_|_| |_| |_|\\___| │");
            Console.WriteLine("│  / __ \\                       │");
            Console.WriteLine("│ | |  | |_   _____ _ __        │");
            Console.WriteLine("│ | |  | \\ \\ / / _ \\ '__|       │");
            Console.WriteLine("│ | |__| |\\ V /  __/ |          │");
            Console.WriteLine("│  \\____/  \\_/ \\___|_|          │");
            Console.WriteLine("└───────────────────────────────┘");
        }
    }
}
