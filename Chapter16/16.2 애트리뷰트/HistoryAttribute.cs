using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

[System.AttributeUsage(System.AttributeTargets.Class,AllowMultiple = true)]
class History : System.Attribute
{
    private string programmer;
    public double version;
    public string changes;

    public History(string programmer)
    {
        this.programmer = programmer;
        version = 1.0;
        changes = "First release";
    }

    public string GetProgrammer()
    {
        return programmer;
    }
}

[History("aaa",version =0.1,changes ="222")]
[History("ddd", version = 0.2, changes = "444")]
class MyClass
{

}
public class HistoryAttribute : MonoBehaviour
{
    void Start()
    {
        Type type = typeof(MyClass);
        Attribute[] attributes = Attribute.GetCustomAttributes(type);

        foreach (Attribute attribute in attributes) 
        {
            History h = attribute as History;
            if (h != null) 
            {
                Debug.Log(h.version + " " + h.GetProgrammer() + " " + h.changes);
            }
        }
    }


}
