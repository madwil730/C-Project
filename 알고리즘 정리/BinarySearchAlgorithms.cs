using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchAlgorithms : MonoBehaviour
{
	void Start()
	{
		int[] datas = new int[] { 1, 2, 3, 5, 12, 13, 31, 53, 56 };

		int result = BSearch(datas, 5);

		Debug.Log($"array index : {result}");
	}

	int BSearch(int[] arr, int target)
	{
		int low = 0;
		int high = arr.Length - 1;
		int mid;

		while (low <= high)
		{
			mid = (low + high) / 2;

			if (arr[mid] == target)
				return mid;
			else if (arr[mid] > target)
				high = mid - 1;
			else
				low = mid + 1;
		}
		return -1;
	}
}
