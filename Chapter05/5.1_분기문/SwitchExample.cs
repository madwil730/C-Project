using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string day = "화";

        switch(day)
        {
            case "일":
                Debug.Log("일요일");
                break;
			case "월":
				Debug.Log("월요일");
				break;
			case "화":
				Debug.Log("화요일");
				break;
			case "수":
				Debug.Log("수요일");
				break;
			case "목":
				Debug.Log("목요일");
				break;
			case "금":
				Debug.Log("금요일");
				break;
			case "토":
				Debug.Log("토요일");
				break;
		
		}
    }

    
}
