using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TupleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //������ ���� Ʃ��
        var a = ("���", 123);
        Debug.Log($"{a.Item1},{a.Item2}");

        // ���� Ʃ��
		var b = (Name:"�ٳ���", Age:456);
		Debug.Log($"{b.Item1},{b.Item2}");

        //����
        var (name, age) = b;
		Debug.Log($"{name},{age}");

		//����2
		var (name2, age2) = ("���",777);
		Debug.Log($"{name},{age}");

        // ���� Ʃ�� = ������ ����  Ʃ��
        b = a;
		Debug.Log($"{b.Name},{b.Age}");
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
