using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication4
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			Stack<string> stack = new Stack<string>(num);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < num; i++)
			{
				string[] str = Console.ReadLine().Split();
				if (str[0] == "1")
				{
					stack.Push(str[1]);
				}
				else if (str[0] == "2")
				{
					if (stack.Count > 0) sb.Append(stack.Pop() + "\n");
					else sb.Append("-1" + "\n");
				}
				else if (str[0] == "3")
				{
					sb.Append(stack.Count + "\n");
				}
				else if (str[0] == "4")
				{
					if (stack.Count > 0) sb.Append("0" + "\n");
					else sb.Append("1" + "\n");
				}
				else if (str[0] == "5")
				{
					if (stack.Count > 0) sb.Append(stack.Peek() + "\n");
					else sb.Append("-1" + "\n");
				}
			}
			Console.WriteLine(sb);
		}
	}
}