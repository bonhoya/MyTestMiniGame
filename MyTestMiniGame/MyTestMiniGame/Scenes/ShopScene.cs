using MyTestMiniGame.Objects;

namespace MyTestMiniGame.Scenes
{
    public class ShopScene : FieldScene
    {
        public ShopScene()
        {
            name = "Shop";

            mapData = new string[]
            {
                "###################################################",
                "#   \\                                         /  #",
                "#    \\_______________________________________/   #",
                "#     │                   /        \\        │    #",
                "#     │       ____       /──────────\\       │    #",
                "#     │      / $ \\       │          │       │    #",
                "#     │      \\_ _/       │          │ ______│    #",
                "#     │      / ┘└ \\      │          │/______\\    #",
                "#     │___ _/│____│\\__ __│          ││______│    #",
                "#     /   / └      ┘ \\   │          ││──────│    #",
                "#    /   /────────────\\  └──────────┘└──────┘    #",
                "#   /    │            │                       \\  #",
                "#  /     └───── ──────┘                        \\ #",
                "# /                                             \\#",
                "#/                                               #",
                "###################################################"
            };

            map = new bool[16, 50];
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
            objects.Add(new Portal("HomeTown", new Vector2(15, 14), 'P'));
            objects.Add(new TalkToChar("Shopper", new Vector2(15, 12), 'T'));
        }
        public override void Enter()
        {
            if (Game.preSceneName == "HomeTown")
            {
                Game.Player.playerPos = new Vector2(15, 14);
            }
            else
            {
                Game.Player.playerPos = new Vector2(41, 5);
            }
            Game.Player.map = map;

        }
    }
}

