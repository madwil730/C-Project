using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Async : MonoBehaviour
{
    async private void MyMethodAsync(int count)
    {
        Debug.Log(111);
        Debug.Log(222);

        await Task.Run(async () =>
        {
            for (int i = 1; i <= count; i++)
            {
                Debug.Log(i / count);
                await Task.Delay(100);
            }
        });

		Debug.Log(333);
		Debug.Log(444);
	}

    void Caller()
    {
        Debug.Log("A");
        Debug.Log("B");

        MyMethodAsync(3);

		Debug.Log("C");
		Debug.Log("D");
	}
    void Start()
    {

        Caller();
    }

   
}
