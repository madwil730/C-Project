using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string day = "ȭ";

        switch(day)
        {
            case "��":
                Debug.Log("�Ͽ���");
                break;
			case "��":
				Debug.Log("������");
				break;
			case "ȭ":
				Debug.Log("ȭ����");
				break;
			case "��":
				Debug.Log("������");
				break;
			case "��":
				Debug.Log("�����");
				break;
			case "��":
				Debug.Log("�ݿ���");
				break;
			case "��":
				Debug.Log("�����");
				break;
		
		}
    }

    
}
