
using MyTestMiniGame.Objects.Jewels;
using MyTestMiniGame.Scenes;
using System.Security.Cryptography.X509Certificates;

namespace MyTestMiniGame.Scenes
{
    public class HomeScene : FieldScene
    {

        public HomeScene()
        {
            name = "Home";

            mapData = new string[]
            {
                "##############################",
                "#  │   │       ┌┐       ┌┬┘  #",
                "#  │   │       └┘   ┌─┐  ├─┘ #",
                "#  │  /└────────────┘ └─│┴│──#",
                "#  │ /                  └─┘  #",
                "#__│/                        #",
                "#                            #",
                "#               /〓/│ ┌──────#",
                "#              /──/   │      #",
                "#             ├──┤    │      #",
                "#─────────────────────┴──────#",
                "#                            #",
                "#                            #",
                "##############################"
            };

            map = new bool[14, 30];
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
            objects.Add(new Portal("HomeTown", new Vector2(21, 3), 'P'));
            objects.Add(new DiamondJewel(new Vector2(7, 5)));

        }
        public override void Enter()
        {
            if (Game.preSceneName == "HomeTown")
            {
                Game.Player.playerPos = new Vector2(21, 3);
            }
            else
            {
                Game.Player.playerPos = new Vector2(15, 8);
            }
            Game.Player.map = map;

        }


    }
}
