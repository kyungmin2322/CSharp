namespace CS20250225
{
    public class DynamicArray<T>
    {
        const int defaultsize = 10;
        T[] objects = new T[defaultsize];

        public int Count = 0; // 실제 사용된 개수
        public int Capacity { get { return objects.Length; } }

        public void Add(T item)
        {
            if(Count >= Capacity)
            {
                T[] newArray = new T[Count * 2];
                for(int i = 0; i < Count; i++)
                {
                    newArray[i] = objects[i];
                }
                objects = newArray;
            }
            objects[Count] = item;
            Count++;
        }

        public T this[int index]
        {
            get { return objects[index]; }
            set { objects[index] = value; }
        }

        public void RemoveAt(int index)
        {
            for(int i = index; i < Count - 1; i++)
            {
                objects[i] = objects[i + 1];
            }
            objects[Count - 1] = default(T);
            Count--;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<object> da = new DynamicArray<object>();

            da.Add(1);
            da.Add(4);
            da.Add(3);
            da.Add(8);
            da.Add(7);
			Console.WriteLine(da.Count);
            da.RemoveAt(2);
            Console.WriteLine(da.Count);
        }
    }
}
