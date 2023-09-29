using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

delegate void EventHandler(string message);

class MyNotifier
{
	public event EventHandler SomethingHappend;
	public void DoSomething(int number)
	{
		int temp = number % 10;

		if (temp != 0 && temp % 3 == 0)
		{
			SomethingHappend(number.ToString() + "¦");
		}
	}
}

public class eventExample : MonoBehaviour
{
   
    public void MyHandler(string message)
    {
        Debug.Log(message);
    }

    void Start()
    {
        MyNotifier notifier = new MyNotifier();
		notifier.SomethingHappend += new EventHandler(MyHandler);

		for(int i = 1; i < 30; i ++)
		{
			notifier.DoSomething(i);
		}
    }


}
