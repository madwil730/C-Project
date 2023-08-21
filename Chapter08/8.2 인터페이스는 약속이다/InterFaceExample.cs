using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

interface ILogger
{
    void Log(string message);
}


class ConsoleLogger : ILogger
{
	public void Log(string message)
	{
        Debug.LogFormat("{0} {1}", DateTime.Now.ToString(), message);
	}

}

class FileLogger : ILogger
{
    private StreamWriter writer;

    public FileLogger(string path)
    {
        writer = File.CreateText(path); 
        writer.AutoFlush = true;
    }

	public void Log(string message)
	{
		Debug.LogFormat("{0} {1}", DateTime.Now.ToString(), message);
	}
}

class ClimateMonitor
{
    private ILogger logger;

    public ClimateMonitor(ILogger logger)
	{
		this.logger = logger;
	}

    public void input(int num)
    {
        logger.Log("현재 온도 : " + num);
    }
}


public class InterFaceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

        monitor.input(5);
		monitor.input(10);
		monitor.input(23);
	}

 
}
