using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ALogger
{
    void Log(string message);

    void LogError(string error)
    {
        Debug.Log(error);
    }
}

class ConsoleLogger2 : ALogger
{
	public void Log(string message)
	{
		throw new System.NotImplementedException();
	}
}

public class InterfaceMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ALogger logger = new ConsoleLogger2();
        logger.Log("Hello");
        logger.LogError("Error");

		ConsoleLogger2 Console = new ConsoleLogger2();
		Console.Log("Hello");
		//Console.LogError("Error"); // 컴파일 에러
	}

   
}
