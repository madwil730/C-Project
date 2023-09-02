using System;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{

	private bool CheckPassed(int score)
	{
		return score >= 60;
	}

	private void Print(int value)
	{
		Debug.Log(value);
	}

	void Start()
	{
		int[] scores = new int[] { 80, 74, 81, 90, 34 };

		foreach (int score in scores)
		{ 
			Debug.Log(score); // 80,74,81,90,34
		}

		Array.Sort(scores); //34,74,80,81,90
		Array.ForEach<int>(scores, new Action<int>(Print));

		Debug.Log("Dimensions :" + scores.Rank); //1
		Debug.Log("BinarySearch :" + Array.BinarySearch<int>(scores, 81)); //3
		Debug.Log("IndexOf :" + Array.IndexOf(scores, 90)); // 4
		Debug.Log("Passed :" + Array.TrueForAll<int>(scores, CheckPassed)); // false

		int index = Array.FindIndex<int>(scores, (score) => score < 60);
		scores[index] = 61;

		Debug.Log("Passed :" + Array.TrueForAll<int>(scores, CheckPassed));  // true
		Debug.Log("GetLength :" + scores.GetLength(0)); //5

		Array.Resize<int>(ref scores, 10);
		Debug.Log("Length :" + scores.Length); // 10

		Array.ForEach<int>(scores, new Action<int>(Print)); //61 74 80 81 90 0 0 0 0 0

		Array.Clear(scores, 3, 7);
		Array.ForEach<int>(scores, new Action<int>(Print)); //61 74 80 0 0 0 0 0 0 0

		int[] sliced = new int[3];
		Array.Copy(scores, 0, sliced, 0, 3);
		Array.ForEach<int>(sliced, new Action<int>(Print)); // 61 74 80
	}


}
