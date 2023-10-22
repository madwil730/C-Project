using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Textfile : MonoBehaviour
{

	void Start()
	{
		using (StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)))
		{
			sw.WriteLine(int.MaxValue);
			sw.WriteLine("Good moring");
			sw.WriteLine(uint.MaxValue);
		}

		using (StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open)))
		{
			while (sr.EndOfStream == false) 
			{
				Debug.Log(sr.ReadLine());	
			}
		}
	}



}
