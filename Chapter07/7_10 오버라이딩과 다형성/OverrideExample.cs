using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideExample : MonoBehaviour
{
    void Start()
    {
		Car mammal = new Car();
		mammal.Initalize();

		Car dog = new bus();	
		dog.Initalize();
    }
}


class Car
{
	public virtual void Initalize()
	{
		Debug.Log("Mammal");
	}
}

class bus : Car
{
	public override void Initalize()
	{
		base.Initalize();
		Debug.Log("Bark");
	}
}
