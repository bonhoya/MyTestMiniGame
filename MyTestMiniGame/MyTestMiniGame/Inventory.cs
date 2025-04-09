using MyTestMiniGame.Objects;

namespace MyTestMiniGame
{
    public class Inventory
    {
        public List<Item> items;
        private Stack<string> stack;
        private int selectIndex;

        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        public Inventory()
        {
            items = new List<Item>(5);
            stack = new Stack<string>();
            gold = 1000;
            
        }

        // 아이템의 추가
        public void Add(Item item)
        {
            items.Add(item);
        }
        // 아이템의 삭제

        public void Remove(Item item)
        {
            items.Remove(item);
        }
        // 아이템의 사용
        public void Use(int index)
        {
            items[index].Use();
        }
        // 아이템의 선택 제거
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public void PrintAll()
        {
            Console.WriteLine("━━ 인벤토리 ━━━━━━━━━━━━━━━━━━");
            if (items.Count == 0)
            {
                Console.WriteLine("인벤토리는 텅텅 비어있다!");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, items[i].name);
            }
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("━━ 골드 ━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("현재 가진 골드: {0}", gold);
            Console.WriteLine("━━ 체력 ━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("현재 가진 체력: {0}", (new Player().CurHP));
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        public void Open()
        {
            stack.Push("Menu");
            while (stack.Count > 0)
            {
                switch (stack.Peek())
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                    case "DropConfirm":
                        DropConfirm();
                        break;
                }
            }
        }

        private void Menu()
        {
            Console.Clear();
            PrintAll();
            Console.WriteLine("1. 아이템을 사용한다.");
            Console.WriteLine("2. 아이템을 버린다.");
            Console.WriteLine("0. 인벤토리를 나간다.");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;


            }
        }

        private void UseMenu()
        {
            Console.Clear();
            PrintAll();
            Console.WriteLine("사용할 아이템을 선택해주세요.");
            Console.WriteLine("0. 뒤로가기");


            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || select >= items.Count)
                {
                    Console.WriteLine("올바른 아이템을 선택해주세요.");
                    Console.ReadKey(true);
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm");
                }
            }
        }

        private void DropMenu()
        {
            Console.Clear();
            PrintAll();
            Console.WriteLine("버릴 아이템을 선택해주세요.");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if(select < 0 || select >= items.Count)
                {
                    Console.WriteLine("올바른 아이템을 선택해주세요.");
                    Console.ReadKey(true);
                }
                else
                {
                    selectIndex = select;
                    stack.Push("DropConfirm");
                }
            }

        }

        private void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} : 아이템을 사용하시겠습니까? (Y/N)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Console.WriteLine("{0} : 아이템을 사용했습니다.", selectItem.name);
                    Console.ReadKey(true);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    Console.WriteLine("아이템을 사용하지 않았습니다.");
                    Console.ReadKey(true);
                    stack.Pop();
                    break;
            }
        }

        private void DropConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} : 아이템을 버리시겠습니까? (Y/N)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;

            switch(input)
            {
                case ConsoleKey.Y:
                    items.Remove(selectItem);
                    Console.WriteLine("{0} : 아이템을 버렸습니다.", selectItem.name);
                    Console.ReadKey(true);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    Console.WriteLine("아이템을 버리지 않았습니다.");
                    Console.ReadKey(true);
                    stack.Pop();
                    break;
            }
        }

    }
}
