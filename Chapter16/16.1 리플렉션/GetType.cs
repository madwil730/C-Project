using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class GetType : MonoBehaviour
{
    void Start()
    {
        int a = 0;
        Type type = a.GetType();

        PrintInterfaces(type);
        PrintFields(type);  
        PrintMehtods(type); 
        PrintProperties(type);  

	}

    public void PrintInterfaces(Type type)
    {
		Debug.Log("----interface----");
		Type[] interfaces = type.GetInterfaces();
        foreach (Type intf in interfaces) 
        {
            Debug.Log(intf.Name);
        }

    }

	public void PrintFields(Type type)
	{
		Debug.Log("----Fields----");
		// 조회 조건
		FieldInfo[] fields = type.GetFields(

            BindingFlags.NonPublic |
			BindingFlags.Public |
		    BindingFlags.Static |
		    BindingFlags.Instance 
			) ;

        foreach(FieldInfo field in fields)
        {
            string accessLevel = "protected";

            if (field.IsPublic)
                accessLevel = "public";

			else if (field.IsPrivate)
				accessLevel = "private";

            Debug.Log(accessLevel + " " + field.FieldType.Name+" "+ field.Name);
		}
	}

    public void PrintMehtods(Type type)
    {
        Debug.Log("----Methods----");
        MethodInfo[] methods = type.GetMethods();
        foreach(MethodInfo method in methods)
        {
            Debug.Log(method.ReturnType.Name + " " + method.Name);

            ParameterInfo[] args = method.GetParameters();    
            for(int i = 0; i <args.Length; i++)
            {
                Debug.Log(args[i].ParameterType.Name);
            }
        }
    }

    public void PrintProperties(Type type)
    {
		Debug.Log("----Properties----");

        PropertyInfo[] properties = type.GetProperties();

        foreach (PropertyInfo property in properties)
            Debug.Log(property.PropertyType.Name + " " + property.Name);

	}


}
