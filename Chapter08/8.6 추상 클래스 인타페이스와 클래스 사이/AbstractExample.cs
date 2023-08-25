using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract class AbstractBase
{
    protected void ProtectMethod()
    {
        Debug.Log("ProtectMethod");
    }

	public void PublicMethod()
	{
		Debug.Log("PublicMethod");
	}

    public abstract void AbstractMethod();
}

class ChildClass : AbstractBase
{
	public override void AbstractMethod()
	{
        Debug.Log("AbstractMethod");
        ProtectMethod();
	}
}


public class AbstractExample : MonoBehaviour
{
    void Start()
    {
        AbstractBase abstractBase = new ChildClass();
        abstractBase.AbstractMethod();
        abstractBase.PublicMethod();
    }

 
}
