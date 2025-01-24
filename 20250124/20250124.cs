namespace C20250124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ~ 100의 홀수/짝수들의 합
            int iEvenSum = 0;
            int iOddSum = 0;

            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 1)
                {
                    iOddSum += i;
                }
                else if(i % 2 == 0)
                {
                    iEvenSum += i;
                }
            }
            Console.WriteLine(iOddSum);
            Console.WriteLine(iEvenSum);
        }
    }
}
