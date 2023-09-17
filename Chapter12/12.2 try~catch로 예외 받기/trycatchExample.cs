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
                Debug.Log(arr[i]); // 3�� ������ ���� �߻�
        }
        catch(IndexOutOfRangeException e)
        {
            Debug.Log("���� �߻� : " + e.ToString()); // �ε����� �迭 ������ ������ϴ�
        }
    }
}
