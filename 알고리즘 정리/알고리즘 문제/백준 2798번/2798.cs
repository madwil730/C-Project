using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();

			string[] input2 = Console.ReadLine().Split();

			//N의 개수
			int count = int.Parse(input[0]);

			//입력 값
			int input_val = int.Parse(input[1]);

			int sum = -1;
			int min = 0;
			int[] num = new int[count];

			for (int i = 0; i < count; i++)
			{
				num[i] = int.Parse(input2[i]);
			}


			for (int i = 0; i < count; i++)
			{
				for (int j = i + 1; j < count; j++)
				{
					for (int k = j + 1; k < count; k++)
					{
						sum = num[i] + num[j] + num[k];

						if (sum <= input_val && min < sum)
						{
							min = sum;
						}

					}

				}
			}
			Console.Write(min);
		}
	}
}