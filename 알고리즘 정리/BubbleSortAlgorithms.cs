using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSortAlgorithms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		int[] nArr = new int[] { 1, 4, 3, 5, 9, 6, 2, 7, 8, 10 };

		int nTemp;
		int nCount = 0;
		for (int i = 0; i < nArr.Length - 1; i++)
		{
			for (int j = 0; j < nArr.Length - 1; j++)
			{
				if (nArr[j] < nArr[j + 1])
				{
					nTemp = nArr[j + 1];
					nArr[j + 1] = nArr[j];
					nArr[j] = nTemp;
				}
				nCount++;
			}
		}

		Debug.LogFormat("Count : {0}",nCount);

		for (int i = 0; i < nArr.Length; i++)
			Debug.Log(nArr[i] + "\t");
	}

  
}
