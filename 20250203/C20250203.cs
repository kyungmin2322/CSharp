namespace _20250203
{
    internal class C20250203
    {
        static void Main(string[] args)
        {
            int iSize = 5;

            for(int i = 1; i <= iSize; i++)
            {
                for(int j = 1; j <= iSize - i; j++)
                {
                    Console.Write(' ');
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
