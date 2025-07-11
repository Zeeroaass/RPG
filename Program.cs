namespace TextRPG
{
    internal class Program
    {
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
            string name = "르탄";
            Console.Clear();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine($"이름:{name} ");
        }
        static void ShopScene()
        {
            Console.Clear();
            Console.WriteLine("3. 상점");
        }

        static void Inventory()
        {
            Console.Clear();
            Console.WriteLine("2. 인벤토리");
        }

        static void Main(string[] args)
        {
            StartScene();
        }
    }
}
