namespace _20250203
{
    internal class C20250203
    {
        static int iSize = 10;
        static int[,] iData = new int[iSize, iSize];
        static void Initialze()
        {

            for (int i = 0; i < iSize; i++)
            {
                for (int j = 0; j < iSize; j++)
                {
                    iData[i, j] = (i * 10) + j + 1;
                }
            }
        }
        static void Print()
        {
            for (int i = 0; i < iSize; i++)
            {
                for (int j = 0; j < iSize; j++)
                {
                    Console.Write(iData[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Initialze();
            Print();
        }
    }
}
