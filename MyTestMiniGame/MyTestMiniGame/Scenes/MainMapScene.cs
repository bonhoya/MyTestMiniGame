using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class MainMapScene : FieldScene
    {
        public MainMapScene()
        {
            name = "MainMap";

            mapData = new string[]
            {
                "##################################################################################",
                "# ┌──────┐                      ┌──────────────────┐                             #",
                "# │'M''$'├───────────┐          │'♣'    'MAZE'     │              ┌────────────┐ #",
                "# │'♠'               │          │                  │              │            │ #",
                "# │'TOWN'├───────┐   │          └───┬┐ ┌┬────┬┐ ┌┬─┘   ┌──────────┤   'BOSS'   │ #",
                "# └──────┘       │   │              │   │    │   │     │                       │ #",
                "#                │   │              │   │    │   │     │   ┌──────┤            │ #",
                "#                │   │              │   │    │   │     │   │      │     'B'    │ #",
                "#        ┌───────┴┐ ┌┴─┐            │   │    │   └─────┘   │      │     '◆'    │ #",
                "#        │             ├────────────┘   │    │             │      └────────────┘ #",
                "#        │  'DUNGEON'                   │    └─────────────┘                     #",
                "#        │'♥'          ├────────────────┘                                        #",
                "#        └─────────────┘                                                         #",
                "###################################################################################"
            };
            map = new bool[14, 83];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (x < mapData[y].Length && picture.Contains(mapData[y][x]))
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
            objects.Add(new Portal("HomeTown", new Vector2(9, 3), 'P'));
            objects.Add(new Portal("DungeonToTown", new Vector2(19, 8), 'P'));
            objects.Add(new Portal("DungeonToMaze", new Vector2(23, 10), 'P'));
            objects.Add(new Portal("MazeToDungeon", new Vector2(38, 4), 'P'));
            objects.Add(new Portal("MazeToBoss", new Vector2(47, 4), 'P'));
            objects.Add(new Portal("Boss", new Vector2(66, 5), 'P'));

        }
        public override void Enter()
        {
            if (Game.preSceneName == "HomeTown")
            {
                Game.Player.playerPos = new Vector2(9, 3);
            }
            else if (Game.preSceneName == "DungeonToTown")
            {
                Game.Player.playerPos = new Vector2(19, 8);
            }
            else if (Game.preSceneName == "DungeonToMaze")
            {
                Game.Player.playerPos = new Vector2(23, 10);
            }
            else if (Game.preSceneName == "MazeToDungeon")
            {
                Game.Player.playerPos = new Vector2(38, 4);
            }
            else if (Game.preSceneName == "MazeToBoss")
            {
                Game.Player.playerPos = new Vector2(47, 4);
            }
            else if (Game.preSceneName == "Boss")
            {
                Game.Player.playerPos = new Vector2(66, 5);
            }
    
            Game.Player.map = map;

        }

    }
}
