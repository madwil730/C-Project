using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexArrayExample : MonoBehaviour
{
    void Start()
    {
        MyList list = new MyList();
        for (int i = 0; i < 5; i++)
            list[i] = i;  // Array Resize 4, Array Resize 5

	}

}
class MyList
{

	private int[] array;

	public MyList()
	{
		array = new int[3];
	}

	public int this[int index]
	{
		get
		{
			return array[index];
		}

		set
		{
			if (index >= array.Length)
			{
				Array.Resize<int>(ref array, index + 1);
				Debug.Log("Array Resize" + array.Length);
			}
		}
	}
}