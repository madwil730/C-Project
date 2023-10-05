using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FriendList
{
	private List<string> list = new List<string>();

	public void Add(string name) => list.Add(name);
	public void Remove(string name) => list.Remove(name);
	public void PrintAll()
	{
		foreach (string name in list)
			Debug.Log(name);
	}

	public FriendList() => Debug.Log("FriendList");

	public int Capacity
	{
		get => list.Capacity;
		set => list.Capacity = value;
	}

	public string this[int index]
	{
		get => list[index];
		set => list[index] = value;	
	}
}

public class ExpressionBodied : MonoBehaviour
{

    void Start()
    {
        FriendList list = new FriendList();
		list.Add("a");
		list.Add("b");
		list.Add("c");
		list.Add("d");
		list.Remove("a");
		list.PrintAll(); // b,c,d

		Debug.Log(list.Capacity); // 4
		list[0] = "q";
		list.PrintAll(); //q,c,d
	}

   
}
