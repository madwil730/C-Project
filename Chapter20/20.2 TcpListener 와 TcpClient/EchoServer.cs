using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class EchoServer : MonoBehaviour
{
    void Start()
    {
     
        string bindIp = "127.0.0.1";
        const int bindPort = 5425;
        TcpListener server = null;

        try
        {
            IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
            server = new TcpListener(localAddress);

            server.Start();

            Debug.Log("Server Start");
            while(true)
            {
                TcpClient client = server.AcceptTcpClient();
                Debug.Log("클라이언트 접속 : " + (IPEndPoint)client.Client.RemoteEndPoint);

                NetworkStream stream = client.GetStream();

                int length;
                string data = null;
                byte[] bytes = new byte[256];

				while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = Encoding.Default.GetString(bytes, 0, length);

                    byte[] msg = Encoding.Default.GetBytes(data);
                    stream.Write(msg, 0, msg.Length);

                    Debug.Log("송신 : " + data);
                }

                stream.Close();
                client.Close();
            }
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
        finally
        {
            server.Stop();
        }
    }

    
}
