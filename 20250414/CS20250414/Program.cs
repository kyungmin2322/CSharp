using System.Text;

namespace CS20250414
{
	class Program
	{
		static void Main(string[] args)
		{
			int lastPush = 0;
			int inNum = int.Parse(Console.ReadLine());

			Queue<int> queue = new Queue<int>();
			StringBuilder sb = new StringBuilder();

			for(int i = 0; i < inNum; i++)
			{
				string[] input = Console.ReadLine().Split(" ");

				if(input.Contains("push"))
				{
					lastPush = int.Parse(input[1]);
					queue.Enqueue(lastPush);
				}
				else if(input.Contains("pop"))
				{
					if(queue.Count == 0)
					{
						sb.AppendLine("-1");
					}
					else
					{
						sb.Append(queue.Dequeue() + "\n");
					}
				}
				else if(input.Contains("size"))
				{
					sb.Append(queue.Count() + "\n");
				}
				else if(input.Contains("empty"))
				{
					if(queue.Count == 0)
					{
						sb.AppendLine("1");
					}
					else
					{
						sb.AppendLine("0");
					}
				}
				else if(input.Contains("front"))
				{
					if(queue.Count() == 0)
					{
						sb.AppendLine("-1");
					}
					else
					{
						sb.Append(queue.First() + "\n");
					}
				}
				else if(input.Contains("back"))
				{
					if(queue.Count() == 0)
					{
						sb.AppendLine("-1");
					}
					else
					{
						sb.Append(lastPush+ "\n");
					}
				}
			}
			Console.WriteLine(sb.ToString());
		}
	}
}