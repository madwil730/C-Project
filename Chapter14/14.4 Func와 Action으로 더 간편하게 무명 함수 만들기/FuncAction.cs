using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class FuncAction : MonoBehaviour
{
    
    void Start()
    {
        Func<int> func1 = () => 10;
        Debug.Log(func1);

		Func<int,int> func2 = (x) => x*2;
        Debug.Log(func2(3)); // 6

        Action act1 = () =>  Debug.Log("ww");
        act1();

        int result = 0;
        Action<int> act2 = (x) => result = x + 2;
        act2(3);

        Debug.Log(result);   // 5



	}

  
}
