using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate int result(int a, int b);
public class delegateCompare : MonoBehaviour
{
	int plus(int a, int b)
	{
		return a + b;
	}

	int minus(int a, int b)
	{
		return a - b;
	}

	public void CallNum(int a, int b,result result)
	{
		Debug.Log(result(a,b));	
	}

	void Start()
    {
	
		CallNum(3,4,new result(plus)); // 7
		CallNum(3,4,new result(minus)); //-1
		
	}

  
}
