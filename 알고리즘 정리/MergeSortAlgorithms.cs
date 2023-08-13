using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MergeSortAlgorithms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		int[] temp = new int [5]{ 1,-3,40,5,2};
		var result = MergeSort(temp, 0, 4);

		foreach ( var i in result)
			Debug.Log(i);
    }

	public  int[] MergeSort(int[] array, int beginIndex, int endIndex)
	{
		if (beginIndex < endIndex)
		{
			int midIndex = (beginIndex + endIndex) / 2;
			MergeSort(array, beginIndex, midIndex);
			MergeSort(array, midIndex + 1, array.Length - 1);
			Merge(array, 0, midIndex, array.Length - 1);
		}

		return array;
	}

	public  void Merge(int[] array, int beginIndex, int midIndex, int endIndex)
	{
		int[] lowHalf = new int[midIndex + 1];
		int[] highHalf = new int[endIndex - midIndex];

		int k = beginIndex;
		int i = 0;
		int j = 0;

		for (i = 0; k <= midIndex; i++, k++)
		{
			lowHalf[i] = array[k];
		}
		for (j = 0; k <= endIndex; j++, k++)
		{
			highHalf[j] = array[k];
		}

		k = beginIndex;
		i = 0;
		j = 0;

		while (i < lowHalf.Length && j < highHalf.Length)
		{
			if (lowHalf[i] < highHalf[j])
			{
				array[k] = lowHalf[i];
				i++;
			}
			else
			{
				array[k] = highHalf[j];
				j++;
			}

			k++;
		}
		while (i < lowHalf.Length)
		{
			array[k] = lowHalf[i];
			i++; k++;
		}
		while (j < highHalf.Length)
		{
			array[k] = highHalf[j];
			j++; k++;
		}
	}
}
