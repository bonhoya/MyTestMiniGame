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
        private static GameClearPrint gameClearPrint = new GameClearPrint();
        private static GameOverPrint gameOverPrint = new GameOverPrint();

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
            sceneDic.Add("GameInfo", new GameInfoScene());
            sceneDic.Add("MainMap", new MainMapScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("Dungeon", new DungeonScene());
            sceneDic.Add("DungeonQuiz", new DungeonQuizScene());
            sceneDic.Add("QuizFail", new QuizFailScene());
            sceneDic.Add("Maze", new MazeScene());
            sceneDic.Add("Boss", new BossScene());
            sceneDic.Add("TalkToBoss", new TalkToBossScene());
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
                if (Game.Player.GameScore == 4)
                {
                    Game.GameClear();
                }
            }

            End();
        }

        // 게임 종료
        private static void End()
        {
            if(Game.Player.GameScore == 1)
            {
                Console.WriteLine("엔딩 1: 조금 모자른(?)자");
                Console.ReadKey(true);
            }
            else if(Game.Player.GameScore == 2)
            {
                Console.WriteLine("엔딩 2: 쥬얼이 3개뿐???");
                Console.ReadKey(true);
            }
            else if(Game.Player.GameScore == 3)
            {
                Console.WriteLine("엔딩 3: 세상은 우리의 것");
                Console.ReadKey(true);
            }
            else if (Game.Player.GameScore == 4)
            {
                Console.WriteLine("엔딩 4: 세상을 구원한자");
                Console.ReadKey(true);
            }

        }

        public static void GameClear()
        {
            Console.SetWindowSize(33, 40);
            Console.Clear();
            gameClearPrint.Print();
            Console.ReadKey(true);
            gameOver = true;
        }

        public static void GameOver()
        {
            Console.SetWindowSize(33, 40);
            Console.Clear();
            gameOverPrint.Print();
            Console.ReadKey(true);
            gameOver = true;
        }
    }
}
