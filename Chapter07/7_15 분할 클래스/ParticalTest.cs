using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class ParticalExample 
{
	public void Method1()
	{
		Debug.Log("Method1");
	}
}

public partial class ParticalExample
{
	public void Method2()
	{
		Debug.Log("Method2");
	}
}

class ParticalTest: MonoBehaviour
{
	private void Start()
	{
		ParticalExample particalExample = new ParticalExample();
		particalExample.Method1();	
		particalExample.Method2();	

	}
}


