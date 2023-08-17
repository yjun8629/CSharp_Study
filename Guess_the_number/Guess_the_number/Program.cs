namespace Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerNum = 0;
            int num = new Random().Next(1, 101);

            while (playerNum != num)
            {
                Console.Write("1에서 100사이의 숫자를 입력해주세요.: ");
                playerNum = int.Parse(Console.ReadLine());

                if (playerNum < num)
                {
                    Console.WriteLine("더 큰 숫자를 입력해주세요!");
                }
                else if (playerNum > num)
                {
                    Console.WriteLine("더 작은 숫자를 입력해주세요!");
                }
                else
                {
                    Console.WriteLine("맞추셨습니다!");
                }
            }
        }
    }
}