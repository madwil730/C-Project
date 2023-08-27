using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace System.Runtime.CompilerServices
{
	internal static class IsExternalInit { }
}


public record Transaction
{
	public string From { get; init; }
	public string To { get; init; }
}

public class RecordExample : MonoBehaviour
{

	void Start()
	{
		Transaction transaction = new Transaction()
		{
			From = "Alice",
			To = "BoB"
		};

		Transaction transaction2 = transaction with { To = "Tom" };


		Debug.Log(transaction); // CTransaction { From = Alice, To = BoB }
		Debug.Log(transaction2); // CTransaction { From = Alice, To = Tom }
		Debug.Log(transaction.Equals(transaction2)); // False
	}

    
}
