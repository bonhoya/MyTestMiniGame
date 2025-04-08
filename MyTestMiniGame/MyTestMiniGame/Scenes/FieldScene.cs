using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame.Scenes
{
    public abstract class FieldScene : SceneOrigin
    {
        protected string[] mapData;
        protected bool[,] map;

        private ConsoleKey input;
        
        public override void Render()
        {
            PrintMap();
            
            Game.Player.Print();
            Console.SetCursorPosition(0, map.GetLength(0) + 2);

        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Game.Player.Move(input);
        }
        public override void Result()
        {

        }
        private void PrintMap()
        {
            for(int y = 0; y < map.GetLength(0); y++)
            {
                for(int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else if (map[y, x] == false)
                    {
                        if (mapData[y][x] == '#')
                        {
                            Console.Write('#');
                        }
                        if (mapData[y][x] == '─')
                        {
                            Console.Write('─');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
