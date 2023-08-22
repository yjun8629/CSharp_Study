namespace personal_assignment_Text_RPG
{
    internal class Program
    {
        static Player player = new Player();
        static Item item1 = new Item();
        static Item item2 = new Item();
        static Item item3 = new Item();
        static Item item4 = new Item();

        static void Main(string[] args)
        {
            item1.name = "낡은 검";
            item1.explanation = "낡은 검이다.";
            item1.price = 0;
            item1.addDefence = 0;
            item1.addAttack = 1;
            item1.isBuy = true;
            item2.name = "무쇠 갑옷";
            item2.explanation = "튼튼한 갑옷이다.";
            item2.price = 0;
            item2.addDefence = 1;
            item2.addAttack = 0;
            item2.isBuy = true;
            item3.name = "조용준의 검";
            item3.explanation = "레어한 조용준의 검이다.";
            item3.price = 50;
            item3.addDefence = 0;
            item3.addAttack = 5;
            item3.isBuy = false;
            item4.name = "조용준의 갑옷";
            item4.explanation = "레어한 조용준의 갑옷이다.";
            item4.price = 50;
            item4.addDefence = 5;
            item4.addAttack = 0;
            item4.isBuy = false;
            item1.CheckEquip();
            item2.CheckEquip();
            item3.CheckEquip();
            item4.CheckEquip();
            StartScene();
        }

        static void StartScene()
        {
            if (item1.isEquip == true)
            {
                player.Attack += item1.addAttack;
                player.Defence += item1.addDefence;
            }
            if (item2.isEquip == true)
            {
                player.Attack += item2.addAttack;
                player.Defence += item2.addDefence;
            }
            if (item3.isEquip == true)
            {
                player.Attack += item3.addAttack;
                player.Defence += item3.addDefence;
            }
            if (item4.isEquip == true)
            {
                player.Attack += item4.addAttack;
                player.Defence += item4.addDefence;
            }

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
                    InventoryScene();
                    isSelect = true;
                }
                else if (input == "3")
                {
                    ShopScene();
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
            item1.CheckEquip();
            item2.CheckEquip();
            item3.CheckEquip();
            item4.CheckEquip();
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
            Console.Write(".　   _＿＿＿_");
            Console.SetCursorPosition(3, 7);
            Console.Write("　　／　　　　＼　");
            Console.SetCursorPosition(3, 8);
            Console.Write("　／　  _ノ 　__ ＼");
            Console.SetCursorPosition(3, 9);
            Console.Write(" ／   　（●）（●）＼");
            Console.SetCursorPosition(3, 10);
            Console.Write(" |　    ///（_人_）///  ");
            Console.SetCursorPosition(3, 11);
            Console.Write(" ＼   　　　 　　 ／");
            Console.SetCursorPosition(3, 12);
            Console.Write("／　 　　　 　  　＼");
            for (int i = 3; i < 16; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(50, 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*SPARTA"); // 캐릭터의 이름
            Console.ResetColor();
            Console.SetCursorPosition(35, 6);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("레 벨");
            Console.ResetColor();
            Console.SetCursorPosition(45, 6);
            Console.Write($"{player.lv}"); // 캐릭터의 레벨
            Console.SetCursorPosition(60, 6);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("직 업");
            Console.ResetColor();
            Console.SetCursorPosition(70, 6);
            Console.Write($"{player.job}"); // 캐릭터의 직업
            Console.SetCursorPosition(35, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("공격력");
            Console.ResetColor();
            Console.SetCursorPosition(45, 10);
            Console.Write($"{player.Attack}"); // 캐릭터의 공격력
            Console.SetCursorPosition(60, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("방어력");
            Console.ResetColor();
            Console.SetCursorPosition(70, 10);
            Console.Write($"{player.Defence}"); // 캐릭터의 방어력
            Console.SetCursorPosition(35, 14);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("체 력");
            Console.ResetColor();
            Console.SetCursorPosition(45, 14);
            Console.Write($"{player.hp}"); // 캐릭터의 체력
            Console.SetCursorPosition(60, 14);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("소지금");
            Console.ResetColor();
            Console.SetCursorPosition(70, 14);
            Console.Write($"{player.gold}"); // 캐릭터의 소지금
            for (int i = 5; i < 16; i++)
            {
                Console.SetCursorPosition(53, i);
                Console.Write("|");
            }
            for (int i = 28; i < 80; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write("-");
            }
            for (int i = 28; i < 53; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write("-");
            }
            for (int i = 28; i < 53; i++)
            {
                Console.SetCursorPosition(i, 12);
                Console.Write("-");
            }
            for (int i = 54; i < 80; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write("-");
            }
            for (int i = 54; i < 80; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write("-");
            }
            for (int i = 54; i < 80; i++)
            {
                Console.SetCursorPosition(i, 12);
                Console.Write("-");
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
        static void InventoryScene()
        {
            item1.CheckEquip();
            item2.CheckEquip();
            item3.CheckEquip();
            item4.CheckEquip();
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
            Console.Write("인벤토리 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("보유중인 아이템을 관리할 수 있습니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(3, 4);
            Console.Write("장착여부");
            Console.SetCursorPosition(13, 4);
            Console.Write("|");
            Console.SetCursorPosition(15, 4);
            Console.Write("아이템명");
            Console.SetCursorPosition(32, 4);
            Console.Write("|");
            Console.SetCursorPosition(35, 4);
            Console.Write("아이템 설명");
            Console.SetCursorPosition(63, 4);
            Console.Write("|");
            Console.SetCursorPosition(65, 4);
            Console.Write("아이템 스탯");

            Console.SetCursorPosition(3, 6);
            Console.Write($"{item1.equip}");
            Console.SetCursorPosition(13, 6);
            Console.Write("|");
            Console.SetCursorPosition(15, 6);
            Console.Write($"{item1.name}");
            Console.SetCursorPosition(32, 6);
            Console.Write("|");
            Console.SetCursorPosition(35, 6);
            Console.Write($"{item1.explanation}");
            Console.SetCursorPosition(63, 6);
            Console.Write("|");
            Console.SetCursorPosition(65, 6);
            Console.Write($"공격력 +{item1.addAttack}");

            Console.SetCursorPosition(3, 7);
            Console.Write($"{item2.equip}");
            Console.SetCursorPosition(13, 7);
            Console.Write("|");
            Console.SetCursorPosition(15, 7);
            Console.Write($"{item2.name}");
            Console.SetCursorPosition(32, 7);
            Console.Write("|");
            Console.SetCursorPosition(35, 7);
            Console.Write($"{item2.explanation}");
            Console.SetCursorPosition(63, 7);
            Console.Write("|");
            Console.SetCursorPosition(65, 7);
            Console.Write($"방어력 +{item2.addDefence}");

            if (item3.isBuy == true)
            {
                Console.SetCursorPosition(3, 8);
                Console.Write($"{item3.equip}");
                Console.SetCursorPosition(13, 8);
                Console.Write("|");
                Console.SetCursorPosition(15, 8);
                Console.Write($"{item3.name}");
                Console.SetCursorPosition(32, 8);
                Console.Write("|");
                Console.SetCursorPosition(35, 8);
                Console.Write($"{item3.explanation}");
                Console.SetCursorPosition(63, 8);
                Console.Write("|");
                Console.SetCursorPosition(65, 8);
                Console.Write($"공격력 +{item3.addAttack}");
            }

            if (item4.isBuy == true)
            {
                Console.SetCursorPosition(3, 9);
                Console.Write($"{item4.equip}");
                Console.SetCursorPosition(13, 9);
                Console.Write("|");
                Console.SetCursorPosition(15, 9);
                Console.Write($"{item4.name}");
                Console.SetCursorPosition(32, 9);
                Console.Write("|");
                Console.SetCursorPosition(35, 9);
                Console.Write($"{item4.explanation}");
                Console.SetCursorPosition(63, 9);
                Console.Write("|");
                Console.SetCursorPosition(65, 9);
                Console.Write($"방어력 +{item4.addDefence}");
            }

            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 15);
                Console.Write("-");
            }
            Console.SetCursorPosition(3, 17);
            Console.Write("1. 장착 관리");
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
                else if (input == "1")
                {
                    EquipmentScene();
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

        static void EquipmentScene()
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
            Console.Write("장착 관리 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("보유중인 아이템을 관리할 수 있습니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(3, 4);
            Console.Write("번호/상태");
            Console.SetCursorPosition(13, 4);
            Console.Write("|");
            Console.SetCursorPosition(15, 4);
            Console.Write("아이템명");
            Console.SetCursorPosition(32, 4);
            Console.Write("|");
            Console.SetCursorPosition(35, 4);
            Console.Write("아이템 설명");
            Console.SetCursorPosition(63, 4);
            Console.Write("|");
            Console.SetCursorPosition(65, 4);
            Console.Write("아이템 스탯");

            Console.SetCursorPosition(3, 6);
            Console.Write($"1/");
            if (item1.isEquip == true)
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("■");
            }
            else
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("□");
            }
            Console.SetCursorPosition(13, 6);
            Console.Write("|");
            Console.SetCursorPosition(15, 6);
            Console.Write($"{item1.name}");
            Console.SetCursorPosition(32, 6);
            Console.Write("|");
            Console.SetCursorPosition(35, 6);
            Console.Write($"{item1.explanation}");
            Console.SetCursorPosition(63, 6);
            Console.Write("|");
            Console.SetCursorPosition(65, 6);
            Console.Write($"공격력 +{item1.addAttack}");

            Console.SetCursorPosition(3, 7);
            Console.Write($"2/");
            if (item2.isEquip == true)
            {
                Console.SetCursorPosition(5, 7);
                Console.Write("■");
            }
            else
            {
                Console.SetCursorPosition(5, 7);
                Console.Write("□");
            }
            Console.SetCursorPosition(13, 7);
            Console.Write("|");
            Console.SetCursorPosition(15, 7);
            Console.Write($"{item2.name}");
            Console.SetCursorPosition(32, 7);
            Console.Write("|");
            Console.SetCursorPosition(35, 7);
            Console.Write($"{item2.explanation}");
            Console.SetCursorPosition(63, 7);
            Console.Write("|");
            Console.SetCursorPosition(65, 7);
            Console.Write($"방어력 +{item2.addDefence}");

            if (item3.isBuy == true)
            {
                Console.SetCursorPosition(3, 8);
                Console.Write($"3/");
                if (item3.isEquip == true)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.Write("■");
                }
                else
                {
                    Console.SetCursorPosition(5, 8);
                    Console.Write("□");
                }
                Console.SetCursorPosition(13, 8);
                Console.Write("|");
                Console.SetCursorPosition(15, 8);
                Console.Write($"{item3.name}");
                Console.SetCursorPosition(32, 8);
                Console.Write("|");
                Console.SetCursorPosition(35, 8);
                Console.Write($"{item3.explanation}");
                Console.SetCursorPosition(63, 8);
                Console.Write("|");
                Console.SetCursorPosition(65, 8);
                Console.Write($"공격력 +{item3.addAttack}");
            }

            if (item4.isBuy == true)
            {
                Console.SetCursorPosition(3, 9);
                Console.Write($"4/");
                if (item4.isEquip == true)
                {
                    Console.SetCursorPosition(5, 9);
                    Console.Write("■");
                }
                else
                {
                    Console.SetCursorPosition(5, 9);
                    Console.Write("□");
                }
                Console.SetCursorPosition(13, 9);
                Console.Write("|");
                Console.SetCursorPosition(15, 9);
                Console.Write($"{item4.name}");
                Console.SetCursorPosition(32, 9);
                Console.Write("|");
                Console.SetCursorPosition(35, 9);
                Console.Write($"{item4.explanation}");
                Console.SetCursorPosition(63, 9);
                Console.Write("|");
                Console.SetCursorPosition(65, 9);
                Console.Write($"방어력 +{item4.addDefence}");
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
                    InventoryScene();
                    isSelect = true;
                }
                else if (input == "1")
                {
                    if (item1.isEquip == false)
                    {
                        Console.SetCursorPosition(5, 6);
                        Console.Write("■");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                        item1.isEquip = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(5, 6);
                        Console.Write("□");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                        item1.isEquip = false;
                    }
                }
                else if (input == "2")
                {
                    if (item2.isEquip == false)
                    {
                        item2.isEquip = true;
                        Console.SetCursorPosition(5, 7);
                        Console.Write("■");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        item2.isEquip = false;
                        Console.SetCursorPosition(5, 7);
                        Console.Write("□");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                    }
                }
                else if (input == "3" && item3.isBuy == true)
                {
                    if (item3.isEquip == false)
                    {
                        item3.isEquip = true;
                        Console.SetCursorPosition(5, 8);
                        Console.Write("■");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        item3.isEquip = false;
                        Console.SetCursorPosition(5, 8);
                        Console.Write("□");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                    }
                }
                else if (input == "4" && item4.isBuy == true)
                {
                    if (item4.isEquip == false)
                    {
                        item4.isEquip = true;
                        Console.SetCursorPosition(5, 9);
                        Console.Write("■");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        item4.isEquip = false;
                        Console.SetCursorPosition(5, 9);
                        Console.Write("□");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("원하시는 행동을 입력해주세요!: ");
                    }
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

        static void ShopScene()
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
            Console.Write("상점 / ");
            Console.ResetColor();
            Console.SetCursorPosition(13, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("아이템을 구매하거나 판매할 수 있습니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(3, 4);
            Console.Write("번호/상태");
            Console.SetCursorPosition(13, 4);
            Console.Write("|");
            Console.SetCursorPosition(15, 4);
            Console.Write("아이템명");
            Console.SetCursorPosition(32, 4);
            Console.Write("|");
            Console.SetCursorPosition(35, 4);
            Console.Write("아이템 가격");
            Console.SetCursorPosition(63, 4);
            Console.Write("|");
            Console.SetCursorPosition(65, 4);
            Console.Write("아이템 스탯");

            Console.SetCursorPosition(3, 6);
            Console.Write($"1/");
            if (item3.isBuy == true)
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("■");
            }
            else
            {
                Console.SetCursorPosition(5, 6);
                Console.Write("□");
            }
            Console.SetCursorPosition(13, 6);
            Console.Write("|");
            Console.SetCursorPosition(15, 6);
            Console.Write($"{item3.name}");
            Console.SetCursorPosition(32, 6);
            Console.Write("|");
            Console.SetCursorPosition(35, 6);
            Console.Write($"구매시 {item3.price}G, 판매시 {item3.price - 20}G");
            Console.SetCursorPosition(63, 6);
            Console.Write("|");
            Console.SetCursorPosition(65, 6);
            Console.Write($"공격력 +{item3.addAttack}");

            Console.SetCursorPosition(3, 7);
            Console.Write($"2/");
            if (item4.isBuy == true)
            {
                Console.SetCursorPosition(5, 7);
                Console.Write("■");
            }
            else
            {
                Console.SetCursorPosition(5, 7);
                Console.Write("□");
            }
            Console.SetCursorPosition(13, 7);
            Console.Write("|");
            Console.SetCursorPosition(15, 7);
            Console.Write($"{item4.name}");
            Console.SetCursorPosition(32, 7);
            Console.Write("|");
            Console.SetCursorPosition(35, 7);
            Console.Write($"구매시 {item4.price}G, 판매시 {item4.price - 20}G");
            Console.SetCursorPosition(63, 7);
            Console.Write("|");
            Console.SetCursorPosition(65, 7);
            Console.Write($"방어력 +{item4.addDefence}");

            Console.SetCursorPosition(3, 14);
            Console.Write($"보유골드: {player.gold}");

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
                else if (input == "1")
                {
                    if (item3.isBuy == false)
                    {
                        if (player.gold >= 50)
                        {
                            player.gold -= 50;
                            Console.SetCursorPosition(5, 6);
                            Console.Write("■");
                            Console.SetCursorPosition(0, 22);
                            Console.Write("                                                 ");
                            Console.SetCursorPosition(0, 22);
                            Console.Write("구매 완료! 원하시는 행동을 입력해주세요!: ");
                            item3.isBuy = true;
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 22);
                            Console.Write("                                                 ");
                            Console.SetCursorPosition(0, 22);
                            Console.Write("골드 부족! 원하시는 행동을 입력해주세요!: ");
                        }
                    }
                    else
                    {
                        player.gold += 30;
                        Console.SetCursorPosition(5, 6);
                        Console.Write("□");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("판매 완료! 원하시는 행동을 입력해주세요!: ");
                        item3.isBuy = false;
                    }
                }
                else if (input == "2")
                {
                    if (item4.isBuy == false)
                    {
                        if (player.gold >= 50)
                        {
                            player.gold -= 50;
                            item4.isBuy = true;
                            Console.SetCursorPosition(5, 7);
                            Console.Write("■");
                            Console.SetCursorPosition(0, 22);
                            Console.Write("                                                 ");
                            Console.SetCursorPosition(0, 22);
                            Console.Write("구매 완료! 원하시는 행동을 입력해주세요!: ");
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 22);
                            Console.Write("                                                 ");
                            Console.SetCursorPosition(0, 22);
                            Console.Write("골드 부족! 원하시는 행동을 입력해주세요!: ");
                        }
                    }
                    else
                    {
                        player.gold += 30;
                        item4.isBuy = false;
                        Console.SetCursorPosition(5, 7);
                        Console.Write("□");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("판매 완료! 원하시는 행동을 입력해주세요!: ");
                    }
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

    struct Player
    {
        public int lv;
        public string job;
        public int Attack;
        public int Defence;
        public int hp;
        public int gold;

        public Player()
        {
        lv = 1;
        job = "Knight";
        Attack = 1;
        Defence = 1;
        hp = 100;
        gold = 0;
        }
    }

    public class Item
    {
        public string name;
        public string explanation;
        public bool isEquip;
        public bool isBuy;
        public string equip;
        public int addAttack;
        public int addDefence;
        public int price;

        public Item()
        {
            isBuy = false;
            isEquip = false;
        }

        public void CheckEquip()
        {
            if (isEquip == false)
            {
                equip = "[미장착]";
            }
            else
            {
                equip = "[장착중]";
            }
        }
    }
}