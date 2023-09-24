using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Delegate
{


	class Calculator
	{
		public int Plus(int a, int b)
		{
			return a + b;
		}

		public int Minus(int a, int b)
		{
			return a - b;
		}
	}

	public class delegateExample : MonoBehaviour
	{
		delegate int MyDelegate(int a, int b);

		private void Start()
		{
			Calculator calc = new Calculator();
			MyDelegate Callback;

			Callback = new MyDelegate(calc.Plus);
			Debug.Log(Callback(3, 4)); //7 

			Callback = new MyDelegate(calc.Minus);
			Debug.Log(Callback(7, 5)); // 2;
		}

	}

}

