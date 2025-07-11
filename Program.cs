using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace TextRPG
{
    internal class Program
    {
        static int level = 1;
        static string name = "Chad";
        static string job = "전사";
        static int attack = 10;
        static int shield = 5;
        static int hp = 100;
        static int gold = 1500;
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
            Console.Clear();
        }

        static void Main(string[] args)
        {
            StartScene();
        }
    }
}
