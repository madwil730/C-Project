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
				Debug.Log("0 ���� ū ¦��");
			if (num % 2 != 0)
				Debug.Log("0 ���� ū Ȧ��");
		}
		else
			Debug.Log("0 ���� ���� ��");

	}
}
