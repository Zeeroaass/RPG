using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace TextRPG
{
    class Item
    {
        public string itemName { get; set; }
        public string Description { get; set; }
        

        public Item(string itemname, string description)
        {
            itemName = itemname;
            Description = description;
        }
    }
    internal class Program
    {
        static int level = 1;
        static string name = "Chad";
        static string job = "전사";
        static int attack = 10;
        static int shield = 5;
        static int hp = 100;
        static int gold = 1500;

        static List<Item> inventory = new List<Item>()
        {
            new Item("무쇠갑옷", "| 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다."),
            new Item("스파르타의 창", "| 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다."),
            new Item("낡은 검", "| 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.")
        };
        static void StartScene()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("스파르타 던전에 오신 분들 환영합니다");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("\n원하시는 행동을 입력해주세요.");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        MyValue();
                        return;
                    case "2":
                        Inventory();
                        return;
                    case "3":
                        ShopScene();
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        continue;

                }
            }
        }

        static void MyValue()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine($"Lv. {level}");
                Console.WriteLine($"{name} ({job})");
                Console.WriteLine($"공격력: {attack}");
                Console.WriteLine($"방어력: {shield}");
                Console.WriteLine($"체력: {hp}");
                Console.WriteLine($"골드: {gold}G");
                Console.WriteLine("\n 0. 나가기");
                Console.WriteLine("\n원하시는 행동을 입력해주세요");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    StartScene();
                }
                else
                {
                    continue;
                }
            }

        }
        static void ShopScene()
        {
            Console.Clear();
            Console.WriteLine("3. 상점");
        }

        static void Inventory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("\n[아이템 목록]\n");

                for (int i = 0; i < inventory.Count; i++)
                {
                    Item item = inventory[i];
                        Console.WriteLine($"- {i + 1} {item.itemName,-15} {item.Description}");
                }

                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    StartScene();
                }
                else if (input == "1")
                {
                    Console.WriteLine("미완");
                }
                else
                {
                    continue;
                }
            }
        }

        static void Main(string[] args)
        {
            StartScene();
        }
    }
}
