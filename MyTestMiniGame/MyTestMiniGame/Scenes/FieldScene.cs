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
        protected int firstCount = 0;
        protected char[] picture =
        { '#',
          '─',
          '│',
          '┌',
          '┐',
          '└',
          '┘',
          '├',
          '┤',
          '〓',
          '┴',
          '┬',
          '/',
          '\\',
          '_',
          '┼'

        };


        private ConsoleKey input;

        protected List<Object> objects;

        public override void Render()
        {
            Console.SetWindowSize(map.GetLength(1), map.GetLength(0) + 20);
            PrintMap();
            foreach (Object obj in objects)
            {
                obj.Print();
            }

            
            Game.Player.Print();
            

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
            foreach(Object obj in objects)
            {
                if (Game.Player.playerPos.x == obj.ObjPos.x 
                    && Game.Player.playerPos.y == obj.ObjPos.y)
                {
                    obj.Interact(Game.Player);
                }
            }
        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for(int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else if (map[y, x] == false)
                    {
                        if (picture.Contains(mapData[y][x]))
                        {
                            Console.Write(mapData[y][x]);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
