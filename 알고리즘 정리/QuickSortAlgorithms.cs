using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSortAlgorithms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		var result = quickSort(new int[5] { 1, -3, 40, 5, 2 });

		foreach (int i in result)
			Debug.Log(i);

	}

	public int[] quickSort(int[] numbers)
	{
		quickSort(numbers, 0, numbers.Length - 1);
		return numbers;
	}

	public void quickSort(int[] numbers, int start, int end)
	{
		int part2 = partition(numbers, start, end);
		if (start < part2 - 1)
		{
			quickSort(numbers, 0, part2 - 1);
		}
		if (part2 < end)
		{
			quickSort(numbers, part2, end);
		}
	}

	public int partition(int[] numbers, int start, int end)
	{
		int pivot = numbers[(start + end) / 2];
		while (start <= end)
		{
			while (pivot > numbers[start]) start++;
			while (pivot < numbers[end]) end--;

			if (start <= end)
			{
				int temp = numbers[start];
				numbers[start] = numbers[end];
				numbers[end] = temp;

				start++;
				end--;
			}
		}
		return start;
	}
}
