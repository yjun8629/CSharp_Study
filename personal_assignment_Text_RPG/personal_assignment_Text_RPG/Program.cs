namespace personal_assignment_Text_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartScene();
        }

        static void StartScene()
        {
            Console.Clear();

            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
                Console.SetCursorPosition(i, 20);
                Console.Write("-");
            }
            for (int i = 0; i <= 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(80, i);
                Console.Write("|");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(3, 1);
            Console.Write("메인 화면 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("내일배움캠프 조용준 개인과제");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }
            Console.SetCursorPosition(3, 4);
            Console.Write("스파르타 마을에 오신 여러분 환영합니다.");
            Console.SetCursorPosition(3, 5);
            Console.Write("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.SetCursorPosition(3, 7);
            Console.Write("1. 상태 보기");
            Console.SetCursorPosition(3, 8);
            Console.Write("2. 인벤토리 확인");
            Console.SetCursorPosition(3, 9);
            Console.Write("3. 상점 입장");
            Console.SetCursorPosition(3, 10);
            Console.Write("4. 던전 입장");
            Console.SetCursorPosition(3, 11);
            Console.Write("5. 휴식하기");

            bool isSelect = false;
            Console.SetCursorPosition(0, 22);
            Console.Write("원하시는 행동을 입력해주세요.: ");

            while (isSelect == false)
            {
                string input = Console.ReadLine();

                if (input == "1")
                {
                    StatusScene();
                    isSelect = true;
                }
                else if (input == "2")
                {
                    isSelect = true;
                }
                else if (input == "3")
                {
                    isSelect = true;
                }
                else if (input == "4")
                {
                    isSelect = true;
                }
                else if (input == "5")
                {
                    isSelect = true;
                }
                else
                {
                    Console.SetCursorPosition(0, 22);
                    Console.Write("                                                 ");
                    Console.SetCursorPosition(0, 22);
                    Console.Write("올바른 숫자를 입력해주세요!: ");
                }
            }
        }

        static void StatusScene()
        {
            Console.Clear();

            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
                Console.SetCursorPosition(i, 20);
                Console.Write("-");
            }
            for (int i = 0; i <= 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(80, i);
                Console.Write("|");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(3, 1);
            Console.Write("상태 보기 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("캐릭터의 정보가 표시됩니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(3, 6);
            Console.Write(".　         _＿＿＿_");
            Console.SetCursorPosition(3, 7);
            Console.Write("　　／　　　　＼　");
            Console.SetCursorPosition(3, 8);
            Console.Write("　／　  _ノ 　__ ＼");
            Console.SetCursorPosition(3, 9);
            Console.Write(" ／   　（●）（●）＼");
            Console.SetCursorPosition(3, 10);
            Console.Write(" |　    ///（_人_）///  ");
            Console.SetCursorPosition(3, 11);
            Console.Write(" ＼   　　　 　　     ／");
            Console.SetCursorPosition(3, 12);
            Console.Write("／　 　　　 　     　＼");
            for (int i = 3; i < 16; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write("|");
            }
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 16);
                Console.Write("-");
            }
            Console.SetCursorPosition(3, 18);
            Console.Write("0. 나가기");

            bool isSelect = false;
            Console.SetCursorPosition(0, 22);
            Console.Write("원하시는 행동을 입력해주세요.: ");

            while (isSelect == false)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    StartScene();
                    isSelect = true;
                }
                else
                {
                    Console.SetCursorPosition(0, 22);
                    Console.Write("                                                 ");
                    Console.SetCursorPosition(0, 22);
                    Console.Write("올바른 숫자를 입력해주세요!: ");
                }
            }
        }
    }
}