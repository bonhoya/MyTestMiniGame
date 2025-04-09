using MyTestMiniGame.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public class HomeTownScene : FieldScene
    {
        public HomeTownScene()
        {
            name = "HomeTown";

            mapData = new string[]
            {
                "##########################################################",
                "#    /____/   \\___\\     ______ ┌┐    /  ┌┼┼─  \\ /\\│/│ /  #",
                "#   /     \\  /│  /─────│〓〓〓│└┘   /   └┼┼┐   \\ │/│/  / #",
                "#──/│   ┌┐│\\/││ /      │〓〓〓│────/│ ┌┐─┼┼┘┌┐ │\\/│/  / /#",
                "#   │┌─┐└┘││__│/       │      │   //│ └┘┌─┐ └┘ │ \\/  /_/ #",
                "#   └┘ └──┘/                        └───┘ └────┘/   /  \\ #",
                "#                                                  /    \\#",
                "#                                                 /      #",
                "#                                                /│ ┌┐  │#",
                "#           ┐_┌                                   │ └┘  │#",
                "#      _____┘ └_                                  │_____│#",
                "#     /-/-/-/-/-\\                                 │/////│#",
                "#    /-/-/-/-/-/-\\                                 _____│#",
                "##########################################################"
            };

            map = new bool[14, 58];
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
            objects.Add(new Portal("Home", new Vector2(6, 5), 'P'));
            objects.Add(new Potion(new Vector2(13, 5)));
        }
        public override void Enter()
        {
            if (Game.preSceneName == "Home")
            {
                Game.Player.playerPos = new Vector2(6, 5);
            }
            else
            {
                Game.Player.playerPos = new Vector2(15, 8);
            }
            Game.Player.map = map;

        }
    }
}
