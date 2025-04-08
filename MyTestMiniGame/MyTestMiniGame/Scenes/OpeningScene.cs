using MyTestMiniGame.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    internal class OpeningScene : FieldScene
    {
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
            Console.WriteLine("Press The any button to continue.");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }
        public override void Update()
        {

        }
        public override void Result()
        {
            Game.ChangeScene("Home");
        }
    }
}
