using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSortAlgorithms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

		int[] data = { 20, 15, 1, 5, 10 };


		Debug.Log(data[0] + ", "+ data[1] + ", "+ data[2] + ", " + data[3] + ", "+ data[4] );

		//정렬  
		for (int i = 0; i < data.Length; i++)
		{
			int min = i;

			for (int j = i + 1; j < data.Length; j++)
			{
				//최소값 비교
				if (data[min] > data[j])
					min = j;
			}
			Swap(ref data[i], ref data[min]);

		}

		Debug.Log("정렬값  ");
		Debug.Log(data[0] + ", " + data[1] + ", " + data[2] + ", " + data[3] + ", " + data[4]);
	}

	static void Swap(ref int a, ref int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}
}
