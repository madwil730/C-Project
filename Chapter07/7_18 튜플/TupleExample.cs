using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TupleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //명명되지 않은 튜플
        var a = ("사과", 123);
        Debug.Log($"{a.Item1},{a.Item2}");

        // 명명된 튜플
		var b = (Name:"바나나", Age:456);
		Debug.Log($"{b.Item1},{b.Item2}");

        //분해
        var (name, age) = b;
		Debug.Log($"{name},{age}");

		//분해2
		var (name2, age2) = ("멜론",777);
		Debug.Log($"{name},{age}");

        // 명명된 튜플 = 명명되지 않은  튜플
        b = a;
		Debug.Log($"{b.Name},{b.Age}");
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
