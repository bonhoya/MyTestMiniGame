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
                "#         ──────  └     │  │          ┌┘ #",
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
            objects.Add(new Portal("MainMap", new Vector2(10, 2), 'P'));
        }
        

        public override void Enter()
        {
            if (Game.preSceneName == "MainMap")
            {
                Game.Player.playerPos = new Vector2(16, 7);
            }
            Game.Player.map = map;

        }
    }
}
