using UnityEngine;

public class OutExample : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		int a = 20;
		int b = 3;


		Divide(a, b, out int c, out int d);

		Debug.Log($"a: {a},b: {b},a/b: {c},a:%b {d}");
	}

	void Divide(int a, int b, out int c, out int d)
	{
		c = a / b;
		d = a % b;
	}
}
