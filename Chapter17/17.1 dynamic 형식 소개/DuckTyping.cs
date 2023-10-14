using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class Duck
{
    public void Walk()
    {
        Debug.Log("Walk");
    }

	public void Swim()
	{
		Debug.Log("Swim");
	}
}

class Mallard : Duck
{ }

class Robot
{
	public void Walk()
	{
		Debug.Log("Walk");
	}

	public void Swim()
	{
		Debug.Log("Swim");
	}
}
public class DuckTyping : MonoBehaviour
{
    void Start()
    {
		dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };

		foreach (dynamic obj in arr) 
		{ 
			obj.Walk();
			obj.Swim();
		
		}
        
    }


}
