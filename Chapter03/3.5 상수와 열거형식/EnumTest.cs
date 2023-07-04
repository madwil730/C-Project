using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    enum enumTest { a =10, b, c, d =50, e}
	// Start is called before the first frame update
	void Start()
    {
        Debug.Log((int)enumTest.a);
        Debug.Log((int)enumTest.b);
        Debug.Log((int)enumTest.c);
        Debug.Log((int)enumTest.d);
        Debug.Log((int)enumTest.e);
    }

    
}
