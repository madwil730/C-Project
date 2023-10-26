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

        t1.Start(); // DoSomething 실행

		for (int i = 0; i < 5; i++) // t1 스레드의 DoSomething 메소드가 실행되는 동시에 메인 스레드의 반복문도 실행됨
		{
			Debug.Log("Main : "+i);
			Thread.Sleep(10); 
		}

        t1.Join();  //스레드의 종료 대기
	}

    void DoSomething()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("Sub : " + i);
            Thread.Sleep(10); // 10초만큼 cpu를 잠시 멈춤
        }
    }
}
