using UnityEngine;

public class MethodExample : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

		int result = Plus(3, 4);
		Debug.Log(result); //7

		result = Minus(5, 2);
		Debug.Log(result); //3
	}

	public int Plus(int a, int b)
	{
		return a + b;
	}

	public int Minus(int a, int b)
	{
		return a - b;
	}
}
