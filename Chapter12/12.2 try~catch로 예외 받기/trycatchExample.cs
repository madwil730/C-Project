using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trycatchExample : MonoBehaviour
{
   
    void Start()
    {
        int[] arr = { 1, 2, 3 };

        try
        {
            for (int i = 0; i < 5; i++)
                Debug.Log(arr[i]); // 3이 넘으면 예외 발생
        }
        catch(IndexOutOfRangeException e)
        {
            Debug.Log("예외 발생 : " + e.ToString()); // 인덱스가 배열 범위를 벗어났습니다
        }
    }
}
