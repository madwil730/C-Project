using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_2750 : MonoBehaviour
{
	public int[] input;
    void Start()
    {
		int temp = 0;

		//bubblesort 알고리즘
		for (int pass = 0; pass < input.Length ; pass++)
		{
			for (int i = 1; i < input.Length - pass; i++)
			{
				if (input[i - 1] > input[i])
				{
					temp = input[i - 1];
					input[i - 1] = input[i];
					input[i] = temp;
				}
			}
		}

		//결과 출력
		for (int i = 0; i < input.Length; i++)
		{
			Debug.Log(input[i]);	
		}
	}


}
