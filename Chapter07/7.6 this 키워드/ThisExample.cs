using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisExample : MonoBehaviour
{
    int a, b, c;

    public ThisExample()
    {
        a = 1;
		Debug.Log($"ThisExample a:{a}, b:{b}, c:{c}");
	}

	public ThisExample(int b) : this()
	{
		this.b = b;
		Debug.Log($"ThisExample a:{a}, b:{b}, c:{c}");
	}

	public ThisExample(int b,int c) : this(b)
	{
		this.c = c;
		Debug.Log($"ThisExample a:{a}, b:{b}, c:{c}");
	}


	private void Start()
	{
		ThisExample a = new ThisExample();
		ThisExample b = new ThisExample(1);
		ThisExample c = new ThisExample(10, 20);

	}
}


