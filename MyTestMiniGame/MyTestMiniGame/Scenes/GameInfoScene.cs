using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class GameInfoScene : SceneOrigin
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.SetWindowSize(66, 19);
            Console.WriteLine("┌───────────────────────────────┐┌───────────────────────────────┐");
            Console.WriteLine("│                               ││                               │");
            Console.WriteLine("│  게임 조작: ┌───┐ ┌───┐       ││  게임 오브젝트:               │");
            Console.WriteLine("│             │ W │ │ I │       ││    아이콘으로 이루어져 있다.  │");
            Console.WriteLine("│             └───┘ └───┘       ││  'T' = 대화, 'P' = 포탈       │");
            Console.WriteLine("│        ┌───┐┌───┐┌───┐        ││                               │");
            Console.WriteLine("│        │ A ││ S ││ D │        ││  게임 스토리:                 │");
            Console.WriteLine("│        └───┘└───┘└───┘        ││    당신은 세상을 구원하기     │");
            Console.WriteLine("│                               ││    위하여 모험을 나서는데..   │");
            Console.WriteLine("│  W, S, A, D = 상하좌우 이동   ││                               │");
            Console.WriteLine("│  I = 인벤토리 열기            ││  게임 목표:                   │");
            Console.WriteLine("│                               ││    세상을 구원하자!           │");
            Console.WriteLine("│  게임 진행: 스크립트 진행     ││      힌트: 쥬얼               │");
            Console.WriteLine("│    (아무키나 선택지 버튼)     ││                               │");
            Console.WriteLine("└───────────────────────────────┘└───────────────────────────────┘");
            Console.WriteLine("└───────────────────────────────┘└───────────────────────────────┘");
            Console.WriteLine("━━━━━━━━━━ 메인화면으로 돌아가려면 아무키나 누르세요. ━━━━━━━━━━━━");


        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            Game.ChangeScene("Opening");
            Console.SetWindowSize(33, 40);
        }
    }
}
