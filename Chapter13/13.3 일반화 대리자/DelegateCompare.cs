using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DelegateCompare : MonoBehaviour
{
    delegate int Compare<T>(T a, T b);

    int AscendCompare<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b);
    }

	int DescendCompare<T>(T a, T b) where T : IComparable<T>
	{
		return a.CompareTo(b) * -1;
	}

    void BubbleSort<T>(T[] Dataset,Compare<T> Comparer)
    {
        int i = 0;
        int j = 0;
        T temp;

        for(i =0; i <Dataset.Length-1; i++)
        {
            for(j=0; j<Dataset.Length-(i+1); j++)
            {
                if (Comparer(Dataset[j], Dataset[j+1])>0)
                {
                    temp = Dataset[j + 1];
                    Dataset[j + 1] = Dataset[j];
                    Dataset[j] = temp;
                }

            }
        }
    }

	// Start is called before the first frame update
	void Start()
    {
        int[] array = { 3, 6, 1, 10, 2 };

        BubbleSort<int>(array, new Compare<int>(AscendCompare));

        for(int i = 0; i < array.Length; i++)
            Debug.Log(array[i]);

		Debug.Log("#######################");

		string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

		BubbleSort<string>(array2, new Compare<string>(DescendCompare));

		for (int i = 0; i < array2.Length; i++)
			Debug.Log(array2[i]);

	}

   
}
