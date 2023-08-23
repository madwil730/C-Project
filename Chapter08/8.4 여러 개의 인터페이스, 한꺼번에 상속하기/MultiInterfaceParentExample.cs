using System.Collections;
using System.Collections.Generic;
using UnityEngine;


interface IRunnable
{
    void Run();
}

interface IFlyable
{
    void Fly();
}

class FlyingCar : IFlyable, IRunnable
{
	public void Fly()
	{
        Debug.Log("Fly");
	}

	public void Run()
	{
		Debug.Log("Run");
	}
}

public class MultiInterfaceParentExample : MonoBehaviour
{
   
    void Start()
    {
		FlyingCar car = new FlyingCar();    
        car.Run();
        car.Fly();

        IRunnable runnable = car as IRunnable;
        runnable.Run(); 

        IFlyable flyable = car as IFlyable;   
        flyable.Fly();



	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
