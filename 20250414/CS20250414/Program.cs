using System.Text;

namespace CS20250414
{
    class Program
    {
        static void Main(string[] args)
        {
			// 명령의 갯수 입력
			int inNum = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();

			// 명령 종료 조건
			for(int i = 0; i < inNum; i++)
			{
				string input = Console.ReadLine();
				string[] pushing = input.Split(' ');

				StringBuilder sb = new StringBuilder();

				if(input.Contains("push"))
				{
					int pushNum = int.Parse(pushing[1]);
					stack.Push(pushNum);
				}
				else if(input.Contains("pop"))
				{
					if(stack.Count == 0)
					{
						sb.Append(-1);
					}
					else
					{
						sb.Append(stack.Pop());
					}
				}
				else if(input.Contains("size"))
				{
					sb.Append(stack.Count());
				}
				else if(input.Contains("empty"))
				{
					int empty = (stack.Count() > 0) ? 0 : 1;
					sb.Append(empty);
				}
				else if(input.Contains("top"))
				{
					if(stack.Count == 0)
					{
						sb.Append(-1);
					}
					else
					{
						sb.Append(stack.Peek());
					}
				}

				if(!input.Contains("push"))
				{
					Console.WriteLine(sb.ToString());
				}
			}
		}
	}
}
