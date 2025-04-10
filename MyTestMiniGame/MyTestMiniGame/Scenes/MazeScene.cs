using MyTestMiniGame.Objects.Jewels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class MazeScene : FieldScene
    {
        public MazeScene()
        {
            name = "Maze";
            mapData = new string[]
            {
               "###########################################",
               "#┌────────┬──────┬───┬───────────────────┐#",
               "#│        │      │                       │#",
               "#│ ───────┴────┐ │ │ │      ┌─┐ ┌─┐    │ │#",
               "#│             │ └─┘ └──────┘ │ │ └────┘ │#",
               "#│      │                     │ │        │#",
               "#├──────┘ ─────┴───────┐      │ └────────┤#",
               "#│                     └──────┤          │#",
               "#│ ┌────── ──────────┐        ├────────┐ │#",
               "#│ └─────────────────┴────────┘        │ │#",
               "###########################################",
            };
            map = new bool[11, 43];
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
            objects.Add(new Portal("MainMap", new Vector2(40, 9), 'P'));
            objects.Add(new CloverJewel(new Vector2(35, 5)));
        }
        public override void Enter()
        {
            if (Game.preSceneName == "MainMap")
            {
                Game.Player.playerPos = new Vector2(2, 9);
            }
            Game.Player.map = map;

        }
    }
}
