namespace CS20250218_1
{
    class DynamicArray
    {
    }

    class Program
    {
        // Overloading
        // Generic Programming -> meta Programming
        static public void Print<T>(T[] data)
        {
            for(int i = 0; i < data.Length; ++i)
            {
                Console.WriteLine(data[i]);
            }
        }

        //static public T Add<T>(T A, T B) // where T : struct { } 제약조건
        //{
        //    return A + B;
        //}

        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4 };
            //char[] numbersToChar = { 'A', 'B', 'C', 'D' };
            //string[] numbersToString = { "1111", "2222", "3333", "4444" };

            //GameObject[] a = new GameObject[3];

            //a[0] = new GameObject();
            //a[1] = new GameObject();
            //a[2] = new GameObject();

            ////Print<int>(numbers);
            ////Print<char>(numbersToChar);
            ////Print<string>(numbersToString);
            ////Print(gameObjects);

            //return;

            // []                   variable
            // [][][][][]           array
            // [][][][][][][][][][] DynamicArray

            // DataStructure        자료구조

            TDynamicArray<int> a = new TDynamicArray<int>();

            for (int i = 0; i < 10; ++i)
            {
                a.Add(i);
            }

            a[1] = 11;
            a[9] = 29;

            a.RemoveAt(9);
            a.RemoveAt(1);
            a.RemoveAt(3);

            a.Insert(2, 99);

            for (int i = 0; i < a.Count; ++i)
            {
                Console.Write(a[i] + ", ");
            }
        }
    }
}
