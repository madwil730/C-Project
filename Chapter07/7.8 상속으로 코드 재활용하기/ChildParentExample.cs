using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildParentExample : MonoBehaviour
{
	private void Start()
	{
		Base a = new Base("a");
		a.BaseMethod();

		Derived b = new Derived("b");
		b.BaseMethod();
		b.DerivedMethod();
	}

}
class Base
{
	protected string Name;
	public Base(string Name)
	{
		this.Name = Name;
		Debug.Log($"{this.Name}.Base()");
	}

	~Base()
	{
		Debug.Log($"{this.Name}.~Base()");
	}

	public void BaseMethod()
	{
		Debug.Log($"{Name}.BaseMethod()");
	}
}

class Derived : Base
{
	public Derived(string Name) : base(Name)
	{
		Debug.Log($"{this.Name}.Derived()");
	}

	~Derived()
	{
		Debug.Log($"{this.Name}.~Derived()");
	}

	public void DerivedMethod()
	{
		Debug.Log($"{Name}.DerivedMethod()");
	}
}