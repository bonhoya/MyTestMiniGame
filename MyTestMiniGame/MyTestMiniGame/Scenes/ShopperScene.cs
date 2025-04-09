using MyTestMiniGame.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class ShopperScene : SceneOrigin
    {
        
        private ConsoleKey input;

        public ShopperScene()
        {
            name = "Shopper";
        }
        public override void Render()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("안녕하세요. 포션 상점입니다──!!");
            Console.WriteLine("포션을 구매하시거나 팔고 싶으신가요???");
            Console.WriteLine("1. 포션을 구매한다. (-300$)");
            Console.WriteLine("2. 포션을 판매한다. (+200$)");
            Console.WriteLine("0. 나간다.");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
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
            Potion potion = new Potion(new Vector2(0, 0));
            switch (input)
            {
                case ConsoleKey.D1:
                    
                    if ((Game.Player.inventory.gold -= 300) <= 0)
                    {
                        Console.WriteLine("소지금이 부족합니다.");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Game.Player.inventory.gold -= 300;
                        Console.WriteLine("포션을 구매하였습니다. (-300$)");
                        Game.Player.inventory.Add(potion);
                        Console.ReadKey(true);
                    }
                    break;

                case ConsoleKey.D0:
                    Game.ChangeScene("Shop");
                    Game.Player.playerPos = new Vector2(15, 12);
                    break;
            }
        }
        public override void Enter()
        {   
            if (Game.preSceneName == "Shop")
            {
                Game.Player.playerPos = new Vector2(12, 15);
            }
            else
            {
                Game.Player.playerPos = new Vector2(15, 8);
            }
        }
    }
}
