using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class QuizFailScene : SceneOrigin
    {
        public override void Render()
        {
            Console.SetWindowSize(50, 30);
            Console.WriteLine("시스템: 당신은 퀴즈를 보기 좋게 틀렸습니다!!!");
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
            Game.Player.GameScore = 1;
            Game.GameOver();
        }


    }
}
