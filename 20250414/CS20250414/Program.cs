namespace CS20250414
{
    class Program
    {
        struct A
        {

        }

        static void Main(string[] args)
        {
            Stack<int> st = new();

            // push(삽입)
            st.Push(1); // 1
            st.Push(2); // 2 1
            st.Push(3); // 3 2 1

			// peek(읽기)
            int num2 = st.Peek(); // 3 | 3 2 1

			// pop(삭제)
			int num = st.Pop(); // 3 | 2 1
            num = st.Pop(); // 2 | 1
            num = st.Pop(); // 1 | empty
        }
    }
}
