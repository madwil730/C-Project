using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullableTest : MonoBehaviour
{
    int? num;
    // Start is called before the first frame update
    void Start()
    {

        num = null;
        Debug.Log(num.HasValue); //false
        Debug.Log(num != null); //false

        num = 3;

        Debug.Log(num.HasValue); // true
        Debug.Log(num != null);  //true
        Debug.Log(num.Value);  //3
    }
}

