using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etcTest2 : MonoBehaviour
{
	int num = 0;
	private void Start()
	{
		Debug.Log(Fibonacci(5));
	}

	private int Fibonacci(uint number)
	{


		if (number == 0)
		{
			return 0;
		}
		if (number == 1)
		{
			return 1;
		}
		return Fibonacci(number - 1) + Fibonacci(number - 2);
	}

}
