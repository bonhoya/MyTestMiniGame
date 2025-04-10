using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class DungeonQuizScene : SceneOrigin
    {
        Util util = new Util();
        
        public override void Render()
        {
            Console.WriteLine("시스템: 당신이 던전에 들어오자 문이 닫힙니다.");
            Console.ReadKey(true);
            Console.WriteLine("시스템: 순식간에 주변은 어둠으로 뒤덮입니다.");
            Console.ReadKey(true);
            Console.WriteLine("시스템: 당신 앞에 있던 거대한 석상이 천천히 눈을 뜹니다.");
            Console.ReadKey(true);
            Console.WriteLine("시스템: 거대한 석상이 손가락을 움직이자 주변이 보이기 시작합니다.");
            Console.ReadKey(true);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            util.SolwTalk("누가 나를 깨운 것이지...?", ConsoleColor.DarkRed);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.ReadKey(true);
            Console.WriteLine("시스템: 당신은 당당하게 자신이 깨운것이라고 합니다.");
            Console.ReadKey(true);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            util.SolwTalk("나의 잠을 깨우다니... 너... 어리석구나...", ConsoleColor.DarkRed);
            util.SolwTalk("음...? 너 제법 쓸만해 보이는 군...", ConsoleColor.DarkRed);
            util.SolwTalk("나는 퀴즈를 좋아하지...", ConsoleColor.DarkRed);
            util.SolwTalk("퀴즈를 낼테니 맞추면 살려보내주마...", ConsoleColor.DarkRed);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.ReadKey(true);
            Console.WriteLine("시스템: 당신이 고개를 끄덕이자 석상은 기다렸다는 듯, 벽을 가르킵니다.");
            Console.ReadKey(true);
        }
        public override void Input()
        {
           
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            if (Game.preSceneName == "MainMap")
            {
                Game.Player.playerPos = new Vector2(19, 14);
                Game.ChangeScene("Dungeon");
            }
        }
    }
}
