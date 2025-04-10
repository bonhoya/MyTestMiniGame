using MyTestMiniGame.Objects.Jewels;

namespace MyTestMiniGame.Scenes
{
    public class TalkToBossScene : SceneOrigin
    {
        Util util = new Util();
        private ConsoleKey input;
        SpadeJewel spadeJewel = new SpadeJewel(new Vector2(0, 0));
        
        public override void Render()
        {
            name = "TalkToBoss";
            Console.SetWindowSize(77, 40);
            Console.WriteLine("시스템: 당신이 가까이 다가가자, 거대한 악마가 말을 걸어옵니다.");
            Console.ReadKey(true);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            util.SolwTalk("안녕? 작은 인간", ConsoleColor.Green);
            Console.ReadKey(true);
            util.SolwTalk("여기까지 오랫만에 인간이 찾아왔군...", ConsoleColor.Green);
            util.SolwTalk("그래... 무슨일로 찾아왔지...?", ConsoleColor.Green);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("1. 널 없애기 위해 보석을 가져왔다.");
            Console.WriteLine("2. 나와 친구하지 않을래?");
            Console.WriteLine("0. 다음에 다시 올게.");

        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Game.Player.PlayerAction(input);
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    util.SolwTalk("날 죽이겠다고...?", ConsoleColor.DarkRed);
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Console.ReadKey(true);
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    util.SolwTalk("그럼... 뭐가 필요한지는 알고 있겠지...?", ConsoleColor.DarkRed);
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Console.ReadKey(true);
                    if (Game.Player.inventory.items.Any(item => item.name == "다이아몬드 쥬얼")
                        && Game.Player.inventory.items.Any(item => item.name == "하트 쥬얼")
                        && Game.Player.inventory.items.Any(item => item.name == "클로버 쥬얼"))
                    {
                        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        util.SolwTalk("뭐야...? 너 모든 것을 다 가지고 있었잖아...?", ConsoleColor.DarkRed);
                        util.SolwTalk("크아악!!!", ConsoleColor.DarkRed);
                        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        Console.ReadKey(true);
                        Console.WriteLine("시스템: 악마가 소멸하였습니다.");
                        Console.ReadKey(true);
                        Console.WriteLine("시스템: 당신은 악마가 소멸한 자리에서 마지막 쥬얼을 얻었습니다.");
                        Console.ReadKey(true);
                        Game.Player.inventory.items.Add(spadeJewel);
                        Console.WriteLine("시스템: 당신에게는 이제 4개의 쥬얼이 있습니다!!");
                        Console.ReadKey(true);
                        Game.ChangeScene("MainMap");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        util.SolwTalk("뭐야...? 너 모든 쥬얼을 다 모으지 못했군?", ConsoleColor.DarkRed);
                        util.SolwTalk("크하하하하하하하하하하하!!", ConsoleColor.DarkRed);
                        util.SolwTalk("배짱한번 두둑한걸?? 두번의 기회는 없다.", ConsoleColor.DarkRed);
                        util.SolwTalk("이제 사라져라.", ConsoleColor.DarkRed);
                        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        Console.ReadKey(true);
                        Console.WriteLine("시스템: 당신은 악마에게 당했습니다.");
                        Console.ReadKey(true);
                        Game.Player.GameScore = 2;
                        Game.GameOver();
                        break;
                    }
                case ConsoleKey.D2:
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    util.SolwTalk("뭐야...? 나와 친구를 하겠다고...?", ConsoleColor.DarkBlue);
                    util.SolwTalk("크하하하하하하하하하하하!!", ConsoleColor.DarkBlue);
                    Console.ReadKey(true);
                    util.SolwTalk("좋아! 너! 배짱 한번 두둑한데??", ConsoleColor.DarkBlue);
                    util.SolwTalk("너! 내 동료가 돼라!!", ConsoleColor.DarkBlue);
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Console.ReadKey(true);
                    Console.WriteLine("시스템: 당신은 악마와 친해졌습니다.");
                    Console.ReadKey(true);
                    Console.WriteLine("시스템: 세상은 이제 당신과 악마의 것입니다.");
                    Console.ReadKey(true);
                    Game.Player.GameScore = 3;
                    Game.GameOver();
                    break;

                case ConsoleKey.D0:
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    util.SolwTalk("뭐야?? 재미없긴... 썩 꺼져버려라", ConsoleColor.Green);
                    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Console.ReadKey(true);
                    Console.WriteLine("시스템: 당신은 그대로 다시 나갔습니다.");
                    Console.ReadKey(true);
                    Game.ChangeScene("Boss");
                    break;
            }
        }
    }
}
