namespace CS20250331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartPrintStar(5);
        }
        
        static void StartPrintStar(int num)
        {
            // 기저 조건 : 끝내는 조건
            if(num <= 0) // !(num < 5)
            {
                return;
			}
            StartPrintStar(num - 1);

            PrintStarLine(num);
			Console.WriteLine();
        }

        static void PrintStarLine(int starCount)
        {
            if(starCount <= 0)
            {
                return;
            }
            PrintStarLine(starCount - 1);

			Console.Write('*');
        }
    }
}
