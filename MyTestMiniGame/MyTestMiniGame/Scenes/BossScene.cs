using MyTestMiniGame.Objects;

namespace MyTestMiniGame.Scenes
{
    public class BossScene : FieldScene
    {
        public BossScene()
        {
            name = "Boss";
            mapData = new string[]
            {
                "##########################################",
                "#               ┏││____││━━━┓            #",
                "#               ┃└/   \\┘    ┃            #",
                "#////           ┃ \\_ _/     ┃       //// #",
                "#\\\\\\            ┃ / ┘└ \\____┃     \\\\\\    #",
                "#/////│─────────//│____│\\  /┃──────//////#",
                "#____/         /└└ /  / ┘┘/ ┃       \\____#",
                "#   │          ┃  │   │   ┃ /        │   #",
                "#   │          ┌┌┌┘┌┌┌┘━━━┛/         │   #",
                "#───┘                                └───#",
                "#                                        #",
                "#                                        #",
                "#                                        #",
                "#                                        #",
                "##########################################"

            };
            map = new bool[15, 42];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (x < mapData[y].Length && pictureFalse.Contains(mapData[y][x]))
                    {
                        map[y, x] = false;
                    }
                    else
                    {
                        map[y, x] = true;
                    }
                }
            }
            objects = new List<Object>();
            objects.Add(new Portal("MainMap", new Vector2(22, 13), 'P'));
            objects.Add(new TalkToChar("TalkToBoss", new Vector2(22, 9), 'T'));
        }
        public override void Enter()
        {
            if (Game.preSceneName == "MainMap")
            {
                Game.Player.playerPos = new Vector2(22, 13);
            }

            else if (Game.preSceneName == "Boss")
            {
                Game.Player.playerPos = new Vector2(22, 9);
            }

            Game.Player.map = map;

        }
    }
}

