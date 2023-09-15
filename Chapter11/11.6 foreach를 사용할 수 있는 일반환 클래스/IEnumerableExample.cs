using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class MyList<T> : IEnumerable<T>, IEnumerator<T>
{
    private T[] array;
    int postion = -1;

	public MyList()
	{
		array = new T[3];
	}

	public T this[int index]
	{
		get { return array[index]; }

		set 
		{ 
			if (index >= array.Length)
			{
				Array.Resize<T>(ref array, index + 1);
				Debug.Log("Array Resized : " +array.Length);
			}

			array[index] = value;	
		}
	}

	public int Length
	{
		get { return array.Length; }
	}

	public IEnumerator<T> GetEnumerator()
	{
		return this;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this;
	}

	public T Current
	{
		get { return array[postion]; }
	}

	object IEnumerator.Current
	{
		get { return array[postion]; }
	}

	public bool MoveNext()
	{
		if (postion == array.Length - 1)
		{
			Reset();
			return false;
		}

		postion++;
		return (postion < array.Length);	
	}

	public void Reset() { postion = -1; }

	public void Dispose() { }

}


public class IEnumerableExample : MonoBehaviour
{
    void Start()
    {
		MyList<string> str_list = new MyList<string>();
		str_list[0] = "a";
		str_list[1] = "b";
		str_list[2] = "c";
		str_list[3] = "d";
		str_list[4] = "e";
        

		foreach (string str in str_list)
		{ Debug.Log(str); } 

		MyList<int> int_list = new MyList<int>();
		int_list[0] = 0;	
		int_list[1] = 1;	
		int_list[2] = 2;	
		int_list[3] = 3;	
		int_list[4] = 4;	

		foreach(int no in int_list)
			Debug.Log(no);
    }


}
