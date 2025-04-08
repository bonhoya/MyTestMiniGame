using MyTestMiniGame.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public class OpeningScene : FieldScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("┌───────────────────────────────┐");
            Console.WriteLine("│                               │");
            Console.WriteLine("│                               │");
            Console.WriteLine("│      Text                     │");
            Console.WriteLine("│          Adventrue            │");
            Console.WriteLine("│                               │");
            Console.WriteLine("│         : 용사의 모험         │");
            Console.WriteLine("│                               │");
            Console.WriteLine("│                               │");
            Console.WriteLine("│                               │");
            Console.WriteLine("└───────────────────────────────┘");
            Console.WriteLine("             게임 시작           ");
            Console.WriteLine("             게임 설명           ");
            Console.WriteLine("             게임 종료           ");

            Game.ControlKey.Print();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Game.ControlKey.Move(input);
        }
        public override void Result()
        {
            Game.ControlKey.Enter(input);
        }
    }
}
