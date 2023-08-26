using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "Good Morning";

        Debug.Log(str.IndexOf("o")); // 1
        Debug.Log(str.LastIndexOf("o")); //6
        Debug.Log(str.StartsWith("Good")); // true
        Debug.Log(str.EndsWith("Good")); // false
        Debug.Log(str.Contains("Morning")); //true
        Debug.Log(str.Replace("Good", "Bye")); //Bye Moring

        Debug.Log("ABC".ToLower()); // abc
        Debug.Log("abc".ToUpper()); //ABC
        Debug.Log("Happy Friday".Insert(5,"Sunny")); // HappySunny Friday
        Debug.Log("I Don't Love You".Remove(2,6)); //I Love You
        Debug.Log(" No Spaces ".Trim()); // "No Space" 공백 삭제
        Debug.Log(" No Spaces ".TrimStart());  // "No Space " 앞쪽 공백 삭제
        Debug.Log(" No Spaces ".TrimEnd()); // " No Space" 뒤쪽 앞쪽 공백 삭제

        Debug.Log(str.Substring(0,5)); // Good
        Debug.Log(str.Substring(5)); // Morning

        string[] arr = str.Split(new string[] { " " }, System.StringSplitOptions.None);

        foreach(string element in arr)
            Debug.Log(element); // Good, Moring

        string fmt = "{0,-20}{1,-15}{2,30}"; 

        Debug.LogFormat(fmt, "aaa", "bbb", "ccc"); //"aaa                 bbb                                       ccc"
        Debug.LogFormat("item_count : {0}, hp : {1}, name : {2}", 10, 2, "tex"); // item_count : 10, hp : 2, name : tex
	Debug.LogFormat("{0:D}",123); //123
        Debug.LogFormat("{0:X}",123); //7B

        int num = 3;

        Debug.Log($"{num} is number"); //3 is number

    }
}
