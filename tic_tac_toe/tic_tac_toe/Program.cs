namespace tic_tac_toe
{
    internal class Program
    {
        static bool isFinish = false;
        static char[] displayNum = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int tryTime = 0;

        static void Main(string[] args)
        {
            while (isFinish == false)
            {
                ShowDisplay();
                Console.Write("플레이어{0}의 차례입니다. 숫자를 입력해주세요.: ", player);

                int playerChoice;
                playerChoice = int.Parse(Console.ReadLine());
                tryTime += 1;
                if (player == 1)
                {
                    displayNum[playerChoice - 1] = 'O';
                    player = 2;
                }
                else
                {
                    displayNum[playerChoice - 1] = 'X';
                    player = 1;
                }

                GameResult();
            }
        }

        static void ShowDisplay()
        {
            Console.Clear();
            Console.WriteLine("　{0}　|　{1}　|　{2}　", displayNum[0], displayNum[1], displayNum[2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("　{0}　|　{1}　|　{2}　", displayNum[3], displayNum[4], displayNum[5]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("　{0}　|　{1}　|　{2}　", displayNum[6], displayNum[7], displayNum[8]);
        }

        static void GameResult()
        {
            //가로 승리
            if (displayNum[0] == displayNum[1] &&  displayNum[1] == displayNum[2])
            {
                WhoIsWinner(0);
            }
            else if (displayNum[3] == displayNum[4] && displayNum[4] == displayNum[5])
            {
                WhoIsWinner(3);
            }
            else if (displayNum[6] == displayNum[7] && displayNum[7] == displayNum[8])
            {
                WhoIsWinner(6);
            }
            
            //세로 승리
            else if (displayNum[0] == displayNum[3] && displayNum[3] == displayNum[6])
            {
                WhoIsWinner(0);
            }
            else if (displayNum[1] == displayNum[4] && displayNum[4] == displayNum[7])
            {
                WhoIsWinner(1);
            }
            else if (displayNum[2] == displayNum[5] && displayNum[5] == displayNum[8])
            {
                WhoIsWinner(2);
            }
            
            //대각선 승리
            else if (displayNum[0] == displayNum[4] && displayNum[4] == displayNum[8])
            {
                WhoIsWinner(0);
            }
            else if (displayNum[2] == displayNum[4] && displayNum[4] == displayNum[6])
            {
                WhoIsWinner(2);
            }

            //무승부
            else if (tryTime == 9)
            {
                ShowDisplay();
                Console.WriteLine("무승부입니다!");
            }
        }

        static void WhoIsWinner(int i)
        {
            if (displayNum[i] == 'O')
            {
                ShowDisplay();
                Console.WriteLine("플레이어1이 승리했습니다!");
            }
            else
            {
                ShowDisplay();
                Console.WriteLine("플레이어2가 승리했습니다!");
            }

            isFinish = true;
        }
    }
}