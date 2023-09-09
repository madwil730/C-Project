using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnumerableArrayExample : MonoBehaviour
{

    
	// Start is called before the first frame update
	void Start()
    {
		var obj = new MyEnumerator();
		foreach (int i in obj) 
			Debug.Log(i); // 1,2,3
    }
}

class MyEnumerator
{
	int[] numbers = { 1, 2, 3, 4 };
	public IEnumerator GetEnumerator()
	{
		yield return numbers[0]; // 1
		yield return numbers[1]; // 2
		yield return numbers[2]; // 3
		yield break; // GetEnumerator() 중단
		yield return numbers[3]; // 실행 안됨
	}
}