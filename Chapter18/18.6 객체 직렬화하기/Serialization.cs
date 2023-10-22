using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

[Serializable]
class NameCard
{
    public string name;
    public string Phone;
    public int Age;
}


public class Serialization : MonoBehaviour
{
	void Start()
	{
		using (Stream ws = new FileStream("a.dat", FileMode.Create))
		{
			BinaryFormatter serializer = new BinaryFormatter();

			NameCard nc = new NameCard();

			nc.name = "sss";
			nc.Phone = "000";
			nc.Age = 33;
			serializer.Serialize(ws, nc);
		}

		using Stream rs = new FileStream("a.dat", FileMode.Open);
		BinaryFormatter deserializer = new BinaryFormatter();

		NameCard nc2;
		nc2 = (NameCard)deserializer.Deserialize(rs);

		Debug.Log(nc2.name);	
		Debug.Log(nc2.Phone);	
		Debug.Log(nc2.Age);	


	}
   
}
