using UnityEngine;

public class IfExample : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		int num = 5;

		if (num > 0)
		{
			if (num % 2 == 0)
				Debug.Log("0 보다 큰 짝수");
			if (num % 2 != 0)
				Debug.Log("0 보다 큰 홀수");
		}
		else
			Debug.Log("0 보다 작은 수");

	}
}
