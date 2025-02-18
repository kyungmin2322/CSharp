namespace CS20250218_1
{
    class DynamicArray
    {
        public DynamicArray()
        {

        }

        ~DynamicArray()
        {

        }

        public void Add(Object inObject)
        {
            if(CurrentPosition >= objects.Length)
            {
                // 배열 늘리기 작업
                // 이전 정보 옮기기

                Object[] newObjects = new Object[objects.Length * 2];

                // 이전 값 이동
                for(int i = 0; i < objects.Length; ++i)
                {
                    newObjects[i] = objects[i];
                }
                objects = null;
                objects = newObjects;
            }
            objects[CurrentPosition] = inObject;
            CurrentPosition++;
            count = CurrentPosition;
        }

        public void Insert(int insertIndex, Object value)
        {
            for(int i = Count - 1; i >= insertIndex; i--)
            {
                objects[i + 1] = objects[i];
            }
            objects[insertIndex] = value;

        }

        // 특정 배열의 단어 혹은 수를 직접 지정하여 삭제
        public bool Remove(Object removeObject)
        {
            for(int i = 0; i < count; ++i)
            {
                if(removeObject == objects[i])
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        // 단어가 아닌 배열의 위치를 찾아 위치의 배열을 삭제
        public bool RemoveAt(int index)
        {
            if(index >= 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    objects[i] = objects[i + 1];
                }
                count--;

                return true;
            }
            return false;
        }

        protected Object[] objects = new Object[3];

        protected int CurrentPosition = 0;

        public int count = 0;
        public int Count
        {
            get { return count; }
        }

        public Object this[int index]
        {
            get
            {
                return objects[index];
            }
            set
            {
                if(index < objects.Length)
                {
                    objects[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // []                   variable
            // [][][][][]           array
            // [][][][][][][][][][] DynamicArray

            // DataStructure        자료구조

            DynamicArray a = new DynamicArray();

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
