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
        Debug.Log(num.HasValue);
        Debug.Log(num != null);


        num = 3;


        Debug.Log(num.HasValue);
        Debug.Log(num != null);
        Debug.Log(num.Value);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class test
{

}
