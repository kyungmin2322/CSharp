namespace C20250123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iKorean = 10;
            int iMath = 100;
            int iEnglish = 50;

            int iTotal = iKorean + iMath + iEnglish;
            float fAverage = iTotal / 3.0f;
            Console.WriteLine(iTotal);
            Console.WriteLine(fAverage);
        }
    }
}
