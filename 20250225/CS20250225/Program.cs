namespace CS20250225
{
	/* 1교시 동적 배열 클래스
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
    */

	/* 3교시 동적 배열 클래스(강사님)
    class DynamicArray
    {
        protected Object[] data;
        protected int count;

        DynamicArray()
        {
            data = new Object[10];
            count = 0;
        }

        public void Add(Object newData)
        {
            if(count >= data.Length)
            {
                Object[] newArray = new object[data.Length * 2];
                Array.Copy(data, newArray, data.Length);

                data = newArray;
			}
			data[count] = newData;
            count++;
		}

        public void RemoveAt(int index)
        {
            for(int i = index + 1; i < data.Length; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
        }

        public int Count()
        {
            return count;
        }

        public Object this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    */

    /* 5교시 IEnumerable
	public class DynamicArray<T> : IEnumerable<T>, IEnumerable
	{
		protected T[] data;
		protected int count;

		public DynamicArray()
		{
			data = new T[10];
			count = 0;
		}

		public void Add(T newData)
		{
			if(count >= data.Length)
			{
				T[] newArray = new T[data.Length * 2];
				Array.Copy(data, newArray, data.Length);
				data = newArray;
			}
			data[count] = newData;
			count++;
		}

		//[][][2][][][]
		public void RemoveAt(int index)
		{
			for(int i = index + 1; i < data.Length; ++i)
			{
				data[i - 1] = data[i];
			}
			count--;
		}

		public IEnumerator GetEnumerator()
		{
			for(int i = 0; i < count; ++i)
			{
				yield return data[i];
			}
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			for(int i = 0; i < count; ++i)
			{
				yield return data[i];
			}
		}
	}

	class Program
	{
		//  
		//[][][][][][]
		//   ^ //yield return 1;
		static void Main(string[] args)
		{
			DynamicArray<int> dynamicArray = new DynamicArray<int>();
			dynamicArray.Add(1);
			dynamicArray.Add(2);
			dynamicArray.Add(3);
			dynamicArray.Add(4);

			foreach(var value in dynamicArray)
			{
				Console.WriteLine(value);
			}
		}

		class Component
		{
			public virtual void OnTriggerEnter() { }
			public virtual void OnTriggerExt() { }
		}
	}
    */

	public class Program
    {
        static void Main(string[] args)
        {
            /* 1교시 동적 배열 클래스
            DynamicArray<object> da = new DynamicArray<object>();

            da.Add(1);
            da.Add(4);
            da.Add(3);
            da.Add(8);
            da.Add(7);
            Console.WriteLine(da.Count);
            da.RemoveAt(2);
            Console.WriteLine(da.Count);
            */
            /* 3교시 동적 배열 클래스(강사님)
            DynamicArray dynamicArray = new DynamicArray();
            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);
            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);
            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);

            for(int i = 0; i < dynamicArray.Count; i++)
            {
                Console.WriteLine(dynamicArray[i]);
            }
            */


        }
    }
    
}
