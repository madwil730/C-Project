using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySlicedExample : MonoBehaviour
{
    private void PrintArray(System.Array array)
    {
        foreach (var item in array) 
        { Debug.Log(item); }  
    }

    void Start()
    {
        char[] array = new char['Z' - 'A' + 1];
        for (int i = 0; i < array.Length; i++)
            array[i] = (char)('A' + i);

        PrintArray(array[..]);  //0 ���� ���������� , A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
        PrintArray(array[5..]); // 5��° ���� ������ , F G H I J K L M N O P Q R S T U V W X Y Z

		Range range_5_10 = 5..10;
		PrintArray(array[range_5_10]); // 5��°���� 9(10-1)��°���� , F G H I J

		Index last = ^0;
        Range ramge_5_last = 5..last;
        PrintArray(array[ramge_5_last]); // 5��°���� ^���� , F G H I J K L M N O P Q R S T U V W X Y Z
		PrintArray(array[^4..^1]);//������ 4��°���� ^���� 2��°����  // W X Y




	}

  
}
