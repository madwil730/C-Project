using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



class FilterableException : Exception
{
    public int ErrorNo { get; set; }
}

public class WhenExceptionExample : MonoBehaviour
{
    void Start()
    {
        try
        {
            int num = 13;
            if (num < 0 || num > 10)
                throw new FilterableException { ErrorNo = num };

        }
        catch (FilterableException e) when(e.ErrorNo  > 10 )
        {
            Debug.Log("10 보다 크다");
        }
		catch (FilterableException e) when (e.ErrorNo < 0)
		{
			Debug.Log("0 보다 작다");
		}
	}

 
}
