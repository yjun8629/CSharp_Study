namespace Alogorithm_Problem
{
    internal class _230824_01
    {
        static void Main(string[] args)
        {
            string answer = Solution(7);
            Console.WriteLine(answer);
        }

        public static string Solution(int num)
        {
            string answer = "";
            if (num % 2 == 1)
            {
                answer = "Odd";
            }
            else
            {
                answer = "Even";
            }
            return answer;
        }
    }
}