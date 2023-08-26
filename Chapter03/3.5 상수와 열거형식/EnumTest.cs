using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    enum enumTest { a =10, b, c, d =50, e}
	// Start is called before the first frame update
	void Start()
    {
        Debug.Log((int)enumTest.a); // 10
        Debug.Log((int)enumTest.b); // 11
        Debug.Log((int)enumTest.c); // 12
        Debug.Log((int)enumTest.d); // 50
        Debug.Log((int)enumTest.e); // 51
    }

    
}
