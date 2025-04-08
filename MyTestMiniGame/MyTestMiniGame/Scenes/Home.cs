using MyTestMiniGame.Scenes;

namespace MyTestMiniGame
{
    public class Home : FieldScene
    {

        public Home()
        {

            mapData = new string[]
            {
                "##############################",
                "#   ┌┐        ┌┐             #",
                "#   └┘        └┘   ┌─┐       #",
                "#──────────────────┘ └───────#",
                "#                            #",
                "#  ┌〓┐                      #",
                "#  │  │                      #",
                "#  ├──┤                      #",
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
            objects.Add(new Portal("Home", new Vector2(20, 3), 'P'));

            firstCount = 1;
            if (firstCount == 1)
            {
                Game.Player.playerPos = new Vector2(3, 6);
                Game.Player.map = map;
            }
            else
            {
                Game.Player.playerPos = new Vector2(5, 12);
                Game.Player.map = map;

            }
        }



    }
}
