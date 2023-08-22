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
            Console.Clear();

            if (player.lv == 1)
            {
                player.maxHp = 100;
            }
            else if (player.lv == 2)
            {
                player.maxHp = 120;
            }
            else if (player.lv == 3)
            {
                player.maxHp = 140;
            }
            else
            {
                player.maxHp = 160;
            }

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
                    DungeonScene();
                    isSelect = true;
                }
                else if (input == "5")
                {
                    RestScene();
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
                        player.Attack += item1.addAttack;
                        player.Defence += item1.addDefence;
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
                        player.Attack -= item1.addAttack;
                        player.Defence -= item1.addDefence;
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
                        player.Attack += item2.addAttack;
                        player.Defence += item2.addDefence;
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
                        player.Attack -= item2.addAttack;
                        player.Defence -= item2.addDefence;
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
                        player.Attack += item3.addAttack;
                        player.Defence += item3.addDefence;
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
                        player.Attack -= item3.addAttack;
                        player.Defence -= item3.addDefence;
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
                        player.Attack += item4.addAttack;
                        player.Defence += item4.addDefence;
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
                        player.Attack -= item4.addAttack;
                        player.Defence -= item4.addDefence;
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
            Console.Write($"                                ");
            Console.SetCursorPosition(3, 14);
            Console.Write($"보유골드: {player.gold}G");

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
                            Console.SetCursorPosition(3, 14);
                            Console.Write($"                                ");
                            Console.SetCursorPosition(3, 14);
                            Console.Write($"보유골드: {player.gold}G");
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
                        Console.SetCursorPosition(3, 14);
                        Console.Write($"                                ");
                        Console.SetCursorPosition(3, 14);
                        Console.Write($"보유골드: {player.gold}G");
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
                            Console.SetCursorPosition(3, 14);
                            Console.Write($"                                ");
                            Console.SetCursorPosition(3, 14);
                            Console.Write($"보유골드: {player.gold}G");
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
                        Console.SetCursorPosition(3, 14);
                        Console.Write($"                                ");
                        Console.SetCursorPosition(3, 14);
                        Console.Write($"보유골드: {player.gold}G");
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

        static void DungeonScene()
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
            Console.Write("던전 선택 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("입장하실 던전을 선택하실 수 있습니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(3, 4);
            Console.Write("선택 번호");
            Console.SetCursorPosition(13, 4);
            Console.Write("|");
            Console.SetCursorPosition(15, 4);
            Console.Write("난이도");
            Console.SetCursorPosition(32, 4);
            Console.Write("|");
            Console.SetCursorPosition(35, 4);
            Console.Write("보상");
            Console.SetCursorPosition(63, 4);
            Console.Write("|");
            Console.SetCursorPosition(65, 4);
            Console.Write("권장 방어력");

            Console.SetCursorPosition(3, 6);
            Console.Write("1");
            Console.SetCursorPosition(13, 6);
            Console.Write("|");
            Console.SetCursorPosition(15, 6);
            Console.Write("Easy");
            Console.SetCursorPosition(32, 6);
            Console.Write("|");
            Console.SetCursorPosition(35, 6);
            Console.Write("10~16G, 레벨 1이면 레벨업");
            Console.SetCursorPosition(63, 6);
            Console.Write("|");
            Console.SetCursorPosition(65, 6);
            Console.Write("0");

            Console.SetCursorPosition(3, 7);
            Console.Write("2");
            Console.SetCursorPosition(13, 7);
            Console.Write("|");
            Console.SetCursorPosition(15, 7);
            Console.Write("Normal");
            Console.SetCursorPosition(32, 7);
            Console.Write("|");
            Console.SetCursorPosition(35, 7);
            Console.Write("20~26G, 레벨 2이면 레벨업");
            Console.SetCursorPosition(63, 7);
            Console.Write("|");
            Console.SetCursorPosition(65, 7);
            Console.Write("1");

            Console.SetCursorPosition(3, 8);
            Console.Write("3");
            Console.SetCursorPosition(13, 8);
            Console.Write("|");
            Console.SetCursorPosition(15, 8);
            Console.Write("Hard");
            Console.SetCursorPosition(32, 8);
            Console.Write("|");
            Console.SetCursorPosition(35, 8);
            Console.Write("30~36G, 레벨 3이면 레벨업");
            Console.SetCursorPosition(63, 8);
            Console.Write("|");
            Console.SetCursorPosition(65, 8);
            Console.Write("6");

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
                    Easy();
                    isSelect = true;
                }
                else if (input == "2")
                {
                    Normal();
                    isSelect = true;
                }
                else if (input == "3")
                {
                    Hard();
                    isSelect = true;
                }
            }
        }

        static void Easy()
        {
            player.hp -= (50 + 6*(0 - player.Defence));

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
            Console.Write("이지 던전 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("가장 쉬운 난이도의 던전입니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            if (player.hp > 0)
            {
                player.gold += (10 + player.Attack);
                if (player.lv == 1)
                {
                    player.lv += 1;
                    player.hp += 20;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 9);
                Console.Write("던전을 클리어했습니다!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(21, 10);
                Console.Write($"{10 + player.Attack}의 골드를 얻고, 레벨이 {player.lv}이(가) 되었습니다!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(30, 9);
                Console.Write("당신은 쓰러지셨습니다!");
                Console.ResetColor();
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
                    DungeonScene();
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

        static void Normal()
        {
            player.hp -= (90 + 20*(0 - player.Defence));

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
            Console.Write("노말 던전 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("평범한 난이도의 던전입니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            if (player.hp > 0)
            {
                player.gold += (20 + player.Attack);
                if (player.lv == 2)
                {
                    player.lv += 1;
                    player.hp += 20;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 9);
                Console.Write("던전을 클리어했습니다!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(21, 10);
                Console.Write($"{20 + player.Attack}의 골드를 얻고, 레벨이 {player.lv}이(가) 되었습니다!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(30, 9);
                Console.Write("당신은 쓰러지셨습니다!");
                Console.ResetColor();
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
                    DungeonScene();
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

        static void Hard()
        {
            player.hp -= (90 + 40*(5 - player.Defence));

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
            Console.Write("하드 던전 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("가장 어려운 난이도의 던전입니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            if (player.hp > 0)
            {
                player.gold += (30 + player.Attack);
                if (player.lv == 3)
                {
                    player.lv += 1;
                    player.hp += 20;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30, 9);
                Console.Write("던전을 클리어했습니다!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(21, 10);
                Console.Write($"{30 + player.Attack}의 골드를 얻고, 레벨이 {player.lv}이(가) 되었습니다!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(30, 9);
                Console.Write("당신은 쓰러지셨습니다!");
                Console.ResetColor();
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
                    DungeonScene();
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

        static void RestScene()
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
            Console.Write("휴식하기 / ");
            Console.ResetColor();
            Console.SetCursorPosition(15, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("휴식을 취할 방법을 고를 수 있습니다.");
            Console.ResetColor();
            for (int i = 1; i < 80; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("-");
            }

            Console.SetCursorPosition(3, 4);
            Console.Write("번호");
            Console.SetCursorPosition(13, 4);
            Console.Write("|");
            Console.SetCursorPosition(15, 4);
            Console.Write("휴식방법");
            Console.SetCursorPosition(32, 4);
            Console.Write("|");
            Console.SetCursorPosition(35, 4);
            Console.Write("설명");
            Console.SetCursorPosition(63, 4);
            Console.Write("|");
            Console.SetCursorPosition(65, 4);
            Console.Write("체력보상/가격");

            Console.SetCursorPosition(3, 6);
            Console.Write("1");
            Console.SetCursorPosition(13, 6);
            Console.Write("|");
            Console.SetCursorPosition(15, 6);
            Console.Write("의자에 앉기");
            Console.SetCursorPosition(32, 6);
            Console.Write("|");
            Console.SetCursorPosition(35, 6);
            Console.Write("앉아서 휴식을 취한다.");
            Console.SetCursorPosition(63, 6);
            Console.Write("|");
            Console.SetCursorPosition(65, 6);
            Console.Write("+35 / 10G");

            Console.SetCursorPosition(3, 7);
            Console.Write("2");
            Console.SetCursorPosition(13, 7);
            Console.Write("|");
            Console.SetCursorPosition(15, 7);
            Console.Write("침대에 눕기");
            Console.SetCursorPosition(32, 7);
            Console.Write("|");
            Console.SetCursorPosition(35, 7);
            Console.Write("누워서 휴식을 취한다.");
            Console.SetCursorPosition(63, 7);
            Console.Write("|");
            Console.SetCursorPosition(65, 7);
            Console.Write("+70 / 20G");

            Console.SetCursorPosition(3, 8);
            Console.Write("3");
            Console.SetCursorPosition(13, 8);
            Console.Write("|");
            Console.SetCursorPosition(15, 8);
            Console.Write("포션을 먹기");
            Console.SetCursorPosition(32, 8);
            Console.Write("|");
            Console.SetCursorPosition(35, 8);
            Console.Write("회복 포션을 먹는다.");
            Console.SetCursorPosition(63, 8);
            Console.Write("|");
            Console.SetCursorPosition(65, 8);
            Console.Write("maxHP / 30G");

            Console.SetCursorPosition(3, 10);
            Console.Write("4");
            Console.SetCursorPosition(13, 10);
            Console.Write("|");
            Console.SetCursorPosition(15, 10);
            Console.Write("부활의 돌");
            Console.SetCursorPosition(32, 10);
            Console.Write("|");
            Console.SetCursorPosition(35, 10);
            Console.Write("돌의 힘으로 부활한다.");
            Console.SetCursorPosition(63, 10);
            Console.Write("|");
            Console.SetCursorPosition(65, 10);
            Console.Write("maxHP / ALL");

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
                    if (player.gold < 10)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("골드 부족! 원하시는 행동을 입력해주세요!: ");
                    }
                    else if (player.hp <= 0)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("사용 불가! 원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        player.gold -= 10;
                        player.hp += 35;
                        if (player.hp > player.maxHp)
                        {
                            player.hp = player.maxHp;
                        }
                        StartScene();
                        isSelect = true;
                    }
                }
                else if (input == "2")
                {
                    if (player.gold < 20)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("골드 부족! 원하시는 행동을 입력해주세요!: ");
                    }
                    else if (player.hp <= 0)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("사용 불가! 원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        player.gold -= 20;
                        player.hp += 70;
                        if (player.hp > player.maxHp)
                        {
                            player.hp = player.maxHp;
                        }
                        StartScene();
                        isSelect = true;
                    }
                }
                else if (input == "3")
                {
                    if (player.gold < 30)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("골드 부족! 원하시는 행동을 입력해주세요!: ");
                    }
                    else if (player.hp <= 0)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("사용 불가! 원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        player.gold -= 30;
                        player.hp = player.maxHp;
                        StartScene();
                        isSelect = true;
                    }
                }
                else if (input == "4")
                {
                    if (player.hp > 0)
                    {
                        Console.SetCursorPosition(0, 22);
                        Console.Write("                                                 ");
                        Console.SetCursorPosition(0, 22);
                        Console.Write("사용 불가! 원하시는 행동을 입력해주세요!: ");
                    }
                    else
                    {
                        player.gold = 0;
                        player.hp = player.maxHp;
                        StartScene();
                        isSelect = true;
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
        public int maxHp;
        public int gold;

        public Player()
        {
            lv = 1;
            job = "Knight";
            Attack = 1;
            Defence = 1;
            hp = 100;
            maxHp = 0;
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