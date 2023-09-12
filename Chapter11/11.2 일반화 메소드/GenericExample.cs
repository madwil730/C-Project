using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
   void CopyArray<T>(T[] source, T[] target)
	{
		for(int i = 0; i < source.Length; i++)
			target[i] = source[i];	
	}

	private void Start()
	{

		int[] source = { 1, 2, 3, 4, 5 };
		int[] target = new int[source.Length];

		CopyArray<int>(source, target);

		foreach(int i in target)
			Debug.Log(i); // 1,2,3,4,5

		string[] source2 = { "a", "b", "c", "d", "e" };
		string[] target2 = new string[source2.Length];

		CopyArray<string>(source2, target2);

		foreach (string i in target2)
			Debug.Log(i); // a,b,c,d,e
	}
}
