using System.Text;

namespace CS20250414
{
    class Program
    {
        static void Main(string[] args)
        {
			int K = int.Parse(Console.ReadLine());
            int sum = 0;
            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < K; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num == 0) stack.Pop();
                else stack.Push(num);
            }

            foreach(int i in stack)
            {
                sum += i;
            }

			Console.WriteLine(sum);
		}
	}
}
