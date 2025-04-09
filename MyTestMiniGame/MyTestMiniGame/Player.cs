namespace MyTestMiniGame
{
    public class Player
    {
        public Vector2 playerPos;
        public bool[,] map;
        

        private int curhp;
        public int CurHP { get { return curhp; } }

        private int maxhp;
        public int MaxHP { get { return maxhp; } }

        public Inventory inventory;
        public Inventory Inventory { get { return inventory; } }


        public Player()
        {
            inventory = new Inventory();
            maxhp = 100;
            curhp = maxhp;

        }

        public void Heal(int amount)
        {
            curhp += amount;
            if (curhp > maxhp)
            {
                curhp = maxhp;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("P");
            Console.ResetColor();

        }

        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = playerPos;

            switch (input)
            {
                case ConsoleKey.W:
                    targetPos.y--;
                    break;
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
                case ConsoleKey.A:
                    targetPos.x--;
                    break;
                case ConsoleKey.D:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                playerPos = targetPos;
            }
        }
        public void PlayerAction(ConsoleKey input)
        {
            switch(input)
            {
                case ConsoleKey.W:
                case ConsoleKey.S:
                case ConsoleKey.A:
                case ConsoleKey.D:
                    Move(input);
                    break;
                case ConsoleKey.I:
                    Console.SetWindowSize(59, 30);
                    Inventory.Open();
                    break;
            }
        }
    }
}
