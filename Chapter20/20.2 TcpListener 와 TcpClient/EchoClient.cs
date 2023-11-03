using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using UnityEngine;
using System.IO;

public class EchoClient : MonoBehaviour
{
	void Start()
	{

		string bindIp = "127.0.0.1";
		const int bindPort = 5425;
		string serverIp = "127.0.0.1";
		const int serverPort = 5425;
		string message = "aaa";

		try
		{
			IPEndPoint clientaddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
			IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

			TcpClient client = new TcpClient(clientaddress);
			client.Connect(serverAddress);

			byte[] data = System.Text.Encoding.UTF8.GetBytes(message);

			NetworkStream stream = client.GetStream();
			stream.Write(data, 0, data.Length);

			data = new byte[256];

			string responseData = "";
			int bytes = stream.Read(data, 0, data.Length);	
			responseData = Encoding.Default.GetString(data,0,bytes);
			
			stream.Close();	
			client.Close();	

		
			
		}
		catch (Exception e)
		{
			Debug.Log(e);
		}
	}
}
