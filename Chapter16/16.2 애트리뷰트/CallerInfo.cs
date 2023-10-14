using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CallerInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text("www");
    }

    public void Text(string str, [CallerFilePath] string path = "", [CallerLineNumber]int line = 0, [CallerMemberName] string member = "")
    {
        Debug.Log(path + "  " + line + " " + member + " : " + str);
    }

   
}
