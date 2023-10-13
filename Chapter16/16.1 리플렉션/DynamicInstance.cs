using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

class Profile
{
    private string name;
    private string phone;
    public Profile()
    {
        name = "";
        phone = "";
    }

    public Profile(string name, string phone)
	{
		this.name = name;
		this.phone = phone;
	}

    public void Print()
    {
        Debug.Log(name + " " + phone);
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
}
public class DynamicInstance : MonoBehaviour
{
    void Start()
    {
        Type type = Type.GetType("DynamicInstance.Profile");
        Debug.Log(type == null);
        MethodInfo methodInfo = type.GetMethod("Print");
        PropertyInfo nameProperty = type.GetProperty("name");   
        PropertyInfo phoneProperty = type.GetProperty("Phone");   

        object profile = Activator.CreateInstance(type, "aaa", "222");
        methodInfo.Invoke(profile, null);

        profile = Activator.CreateInstance(type);
        nameProperty.SetValue(profile, "bbb", null);
        phoneProperty.SetValue(profile, "444", null);

        Debug.Log(nameProperty.GetValue(profile, null));
        Debug.Log(phoneProperty.GetValue(profile, null));
    }

  
}
