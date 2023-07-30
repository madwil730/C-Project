using System;
using UnityEngine;

public class InsertionSortAlgorithms : MonoBehaviour
{
	int[] arr = new int[10] { 1, 4, 2, 3, 5, 7, 6, 9, 8, 0 }; // �迭�� �����ϰ�

	private void Start()
	{
		Sort();
	}

	// �����Լ��Դϴ�.

	public void Sort()
	{
		// ���� �����̹Ƿ� index�� 1���� ����
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
