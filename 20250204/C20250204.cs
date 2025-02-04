namespace _20250204
{
    internal class C20250204
    {
        static void Main(string[] args)
        {
            int[] array = new int[52];
            Random rand = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            for(int i = 0; i < 8; i++)
            {
                // 랜덤 값 생성
                int arrayNum = rand.Next(i, array.Length);

                Console.Write($"{array[arrayNum]}, ");

                int temp = array[arrayNum];
                array[arrayNum] = array[i];
                array[i] = temp;
            }

        }
    }
}
