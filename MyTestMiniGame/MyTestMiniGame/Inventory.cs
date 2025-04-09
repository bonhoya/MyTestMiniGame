using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTestMiniGame.Objects;

namespace MyTestMiniGame
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
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
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, items[i].name);
            }
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

    }
}
