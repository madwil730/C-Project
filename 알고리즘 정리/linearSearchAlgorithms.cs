using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linearSearchAlgorithms : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
    {
		int[] arr = { 5, 2, 13, 1, 8, 55, 29, 33 };
		int target = 33;

		int num = linearSearch(arr, arr.Length, target);

		if (num >= 0)
		{
			Debug.Log($"Found index : {num} array[index]: {arr[num]}");
		}
		else
		{
			Debug.Log("Not Found");
		}

	}
	int linearSearch(int[] arr, int length, int target)
	{
		int Idx = 0;
		while (Idx < length)
		{
			if (arr[Idx] == target)
				return Idx;
			Idx++;
		}

		return -1;
	}

}
