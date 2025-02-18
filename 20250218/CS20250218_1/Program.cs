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

        public void Remove(Object removeObject)
        {

        }

        public void RemoveAt(int index)
        {

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

            a[9] = 29;

            for (int i = 0; i < a.Count; ++i)
            {
                Console.Write(a[i] + ", ");
            }
        }
    }
}
