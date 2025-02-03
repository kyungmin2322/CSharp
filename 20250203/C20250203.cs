namespace _20250203
{
    internal class C20250203
    {
        static void Main(string[] args)
        {
            int[,] iData = new int[5, 5];
            int iSize = 5;
            for(int i = 0; i < iSize; i++)
            {
                for(int j = 0; j < iSize; j++)
                {
                    Console.Write("*");
                    iData[i, j] = j;
                }
                Console.WriteLine();
            }
        }
    }
}
