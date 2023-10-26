using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BasicThread : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Thread t1 = new Thread(new ThreadStart(DoSomething));

        t1.Start(); // DoSomething ����

		for (int i = 0; i < 5; i++) // t1 �������� DoSomething �޼ҵ尡 ����Ǵ� ���ÿ� ���� �������� �ݺ����� �����
		{
			Debug.Log("Main : "+i);
			Thread.Sleep(10); 
		}

        t1.Join();  //�������� ���� ���
	}

    void DoSomething()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("Sub : " + i);
            Thread.Sleep(10); // 10�ʸ�ŭ cpu�� ��� ����
        }
    }
}
