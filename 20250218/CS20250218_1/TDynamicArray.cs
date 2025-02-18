using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218_1
{
    // Generic Class
    // 박싱, 언박싱으로 성능 떨어지는거 방지위해 사용
    class TDynamicArray<T> // where T : new()
    {
        public TDynamicArray()
        {

        }

        ~TDynamicArray()
        {

        }

        public void Add(T inObject)
        {
            if (count >= objects.Length)
            {
                ExtendSpace();
            }
            objects[count] = inObject;
            count++;
        }

        protected void ExtendSpace()
        {
            // 배열 늘리기 작업
            // 이전 정보 옮기기

            T[] newObjects = new T[objects.Length * 2];

            // 이전 값 이동
            for (int i = 0; i < objects.Length; ++i)
            {
                newObjects[i] = objects[i];
            }
            objects = null;
            objects = newObjects;
        }

        public void Insert(int insertIndex, T value)
        {
            if (objects.Length == count)
            {
                ExtendSpace();
            }

            for (int i = count - 1; i >= insertIndex; i--)
            {
                objects[i + 1] = objects[i];
            }
            objects[insertIndex] = value;
            count++;
        }

        // 특정 배열의 단어 혹은 수를 직접 지정하여 삭제
        public bool Remove(T removeObject)
        {
            for (int i = 0; i < count; ++i)
            {
                if (removeObject.Equals(objects[i]))
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        // 단어가 아닌 배열의 위치를 찾아 위치의 배열을 삭제
        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
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

        protected T[] objects = new T[3];

        protected int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                return objects[index];
            }
            set
            {
                if (index < objects.Length)
                {
                    objects[index] = value;
                }
            }
        }
    }
}
