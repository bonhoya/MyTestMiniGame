using MyTestMiniGame.Scenes;

namespace MyTestMiniGame
{
    public class TownScene : FieldScene
    {

        public TownScene()
        {
            mapData = new string[]
            {
                "##############################",
                "#                            #",
                "#                            #",
                "#────────────────────────────#",
                "#                            #",
                "#                            #",
                "#                            #",
                "#                            #",
                "#                            #",
                "#                            #",
                "#                            #",
                "#                            #",
                "#                            #",
                "##############################"
            };

            map = new bool[14, 30];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (mapData[y][x] == '#')
                    {
                        map[y, x] = false;
                    }
                    else if (mapData[y][x] == '─')
                    {
                        map[y, x] = false;
                    }
                    else
                    {
                        map[y, x] = true;
                    }
                }
            }
        }
    }
}
