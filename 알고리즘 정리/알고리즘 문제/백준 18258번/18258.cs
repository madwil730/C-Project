using System.Collections;
using System.Text;
namespace ConsoleApplication4
{
	class Program
	{
		private static StringBuilder sb;
		private static Queue queue;
		static void Main(string[] args)
		{
			sb = new StringBuilder();
			// 명령 입력
			int num = int.Parse(Console.ReadLine());
			int last = 0;
			queue = new Queue();
			for (int i = 0; i < num; i++)
			{
				string[] str = Console.ReadLine().Split();
				if (str.Length > 1)
				{
					last = int.Parse(str[1]);

				}
				switch (str[0])
				{
					case "push":
						queue.Enqueue(last);
						break;
					case "pop":
						sb.AppendLine(queue.Count != 0 ? queue.Dequeue().ToString() : "-1");
						break;
					case "empty":
						sb.AppendLine(queue.Count == 0 ? "1" : "0");
						break;
					case "size":
						sb.AppendLine(queue.Count.ToString());
						break;
					case "front":
						sb.AppendLine(queue.Count != 0 ? queue.Peek().ToString() : "-1");
						break;
					case "back":
						sb.AppendLine(queue.Count != 0 ? last.ToString() : "-1");
						break;
				}

			}

			Console.WriteLine(sb);

		}
	}
}