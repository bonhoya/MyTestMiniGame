using MyTestMiniGame.Objects.Jewels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class DungeonScene : FieldScene
    {

        public DungeonScene()
        {
            name = "Dungeon";

            mapData = new string[]
            {
                "#########################################",
                "#                                       #",
                "#   ────┐         ────┐     /   ────┐   #",
                "#   ┌───┘   ─┼─   ┌───┘    /    ┌───┘   #",
                "#   └────         └────   /     └────   #",
                "#                                  ___  #",
                "#                 ┌─────┐  ┌──────┘   └┐#",
                "#         ──────  └     │  │_____  ┼  ┌┘ #",
                "#         ──────    ┌───┘   └└──┐─┘  │┘ #",
                "#                   │          ┌┘  ┌ │  #",
                "#    3      2      ┌─┐        ┌┘ ┌ │ │  #",
                "#   ┌─┐    ┌─┐     └─┘        ││ │ │ │  #",
                "#───┘ └────┘ └────────────────││ │ │ │──#",
                "#                            ┌┘┘ ┘ ┘ └┐ #",
                "#                           ┌┘────────└┐#",
                "#                           └──────────┘#",
                "#                                       #",
                "#                                       #",
                "#                                       #",
                "#########################################",

            };
            map = new bool[20, 41];
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
            objects.Add(new Portal("MainMap", new Vector2(5, 12), 'P'));
            objects.Add(new Portal("QuizFail", new Vector2(12, 12), 'P'));
            objects.Add(new HeartJewel(new Vector2(8, 14)));
        }
        

        public override void Enter()
        {

            Game.Player.map = map;

        }
    }
}
