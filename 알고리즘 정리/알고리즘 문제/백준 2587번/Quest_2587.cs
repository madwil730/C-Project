using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_2587 : MonoBehaviour
{

	public int[] arr;
	// Start is called before the first frame update
	void Start()
    {
	
		int avg = 0;

		Array.Sort(arr);

		for (int i = 0; i < 5; i++)
		{
			avg += arr[i];
		}
		avg = avg / 5;

		Debug.Log("Æò±Õ :" +avg);
		Debug.Log("Áß¾Ó°ª :" +arr[2]);
	}

}
