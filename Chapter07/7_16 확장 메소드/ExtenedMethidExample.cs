using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public static class IntergerExtension
{
    public static int Square(this int myInt)
    {
        return myInt * myInt;
    }

    public static int Power(this int myInt, int exponent)
    {
        int result = myInt;
        for(int i =1; i <exponent; i++)
        result *= myInt; 
	    
	return result;
    }

}

public class ExtenedMethidExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(3.Square());
        Debug.Log(3.Power(4));
    }

   
}
