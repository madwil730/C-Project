using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BasicIO : MonoBehaviour
{
    void Start()
    {
        long someValue = 0x123456789ABCDEF0;

        Stream outStream = new FileStream("a.dat", FileMode.Create);
        byte[] wBytes = BitConverter.GetBytes(someValue);

        foreach (byte b in wBytes)  
            Debug.Log(b);

        outStream.Write(wBytes, 0, wBytes.Length);
        outStream.Close();

        Stream inStream  = new FileStream("a.dat", FileMode.Open);
        byte[] rbytes = new byte[8];

        int i = 0;
        while (inStream.Position < inStream.Length)
            rbytes[i++]= (byte)inStream.ReadByte();

        long readValue = BitConverter.ToInt64(rbytes, 0);

        Debug.Log(readValue);
        inStream.Close();
	}

}
