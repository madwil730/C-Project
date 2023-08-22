using System.Collections;
using System.Collections.Generic;
using UnityEngine;



	interface ILogger
	{
		void WriteLog(string message);
	}

	interface IFormattableLogger : ILogger
	{
		void WriteLog(string format,  int args);
	}

class ConsoleLogger : IFormattableLogger
{
	public void WriteLog(string format,  int args)
	{
		string message = format + ": " + args;	
		Debug.Log(message);
	}

	public void WriteLog(string message)
	{
		Debug.Log(message);
	}


}



public class InterfaceParentExample : MonoBehaviour
{
    void Start()
    {
        IFormattableLogger logger = new ConsoleLogger();
		logger.WriteLog("hello");
		logger.WriteLog("hello",10);

    }


}
