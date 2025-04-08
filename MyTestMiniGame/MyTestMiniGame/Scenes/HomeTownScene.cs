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
            mapData = new string[]
            {
                "#############################                #",
                "#   ┌┐        ┌┐       ┌┬┘                   #",
                "#   └┘        └┘   ┌─┐  ├─┘                  #",
                "#──────────────────┘ └─│┴│───                #",
                "#                      └─┘                   #",
                "#  ┌〓┐                                      #",
                "#  │──│                                      #",
                "#  ├──┤               ┌──────                #",
                "#                     │                      #",
                "#                     │                      #",
                "#─────────────────────┴──────                #",
                "#                                            #",
                "#                                            #",
                "#############################                #"
            };

            map = new bool[14, 46];
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
            objects.Add(new Portal("HomeTown", new Vector2(20, 3), 'P'));
        }
        
    }
}
