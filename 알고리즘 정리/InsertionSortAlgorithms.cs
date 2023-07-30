using System;
using UnityEngine;

public class InsertionSortAlgorithms : MonoBehaviour
{
	int[] arr = new int[10] { 1, 4, 2, 3, 5, 7, 6, 9, 8, 0 }; // 배열을 선언하고

	private void Start()
	{
		Sort();
	}

	// 정렬함수입니다.

	public void Sort()
	{
		// 삽입 정렬이므로 index는 1부터 시작
		for (int i = 1; i < arr.Length; i++)
		{
			for (int j = 0; j < i; j++) 
			{
				if (arr[i] < arr[j]) 
					Swap(i, j); 

			}
		}

		foreach (int i in arr) 
		{
			Debug.Log (i + " ");
		}
	}

	public void Swap(int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}
}
