using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "Good Morning";

        Debug.Log(str.IndexOf("o"));
        Debug.Log(str.LastIndexOf("o"));
        Debug.Log(str.StartsWith("Good"));
        Debug.Log(str.EndsWith("Good"));
        Debug.Log(str.Contains("Morning"));
        Debug.Log(str.Replace("Good", "Bye"));

        Debug.Log("ABC".ToLower());
        Debug.Log("abc".ToUpper());
        Debug.Log("Happt Friday".Insert(5,"Sunny"));
        Debug.Log("I Don't Love You".Remove(2,6));
        Debug.Log(" No Spaces ".Trim());
        Debug.Log(" No Spaces ".TrimStart());
        Debug.Log(" No Spaces ".TrimEnd());

        Debug.Log(str.Substring(0,5));
        Debug.Log(str.Substring(5));

        string[] arr = str.Split(new string[] { " " }, System.StringSplitOptions.None);

        foreach(string element in arr)
            Debug.Log(element);

        string fmt = "{0,-20}{1,-15}{2,30}";

        Debug.LogFormat(fmt, "aaa", "bbb", "ccc");
		Debug.LogFormat("item_count : {0}, hp : {1}, name : {2}", 10, 2, "tex");
		Debug.LogFormat("{0:D}",123);
        Debug.LogFormat("{0:X}",123);

        int num = 3;

        Debug.Log($"{num} is number");

    }
}
