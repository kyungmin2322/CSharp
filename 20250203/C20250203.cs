namespace _20250203
{
    internal class C20250203
    {
        static void Main(string[] args)
        {
            int iSize = 10;
            int[,] iData = new int[iSize, iSize];

            for(int i = 0; i < iSize; i++)
            {
                for(int j = 0; j < iSize; j++)
                {
                    iData[i, j] = (i * 10) + j + 1;
                }
            }
            for(int i = 0; i < iSize; i++)
            {
                for(int j = 0; j < iSize; j++)
                {
                    Console.Write(iData[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
