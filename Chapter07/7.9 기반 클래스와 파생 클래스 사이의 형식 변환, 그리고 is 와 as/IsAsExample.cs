using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAsExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mammal mammal = new Dog();
        Dog dog;

        if(mammal is Dog)
        {
            dog = (Dog)mammal;
            dog.Bark();
        }

		Mammal mammal2 = new Cat();

        Cat cat = mammal2 as Cat;
        if (cat != null)
            cat.Meow();

        Cat cat2 = mammal as Cat;

        if (cat2 != null)
            cat2.Meow();
        else
            Debug.Log("cat2 is not a Cat");

	}

  
}

class Mammal
{
    public void Nurse()
    {
        Debug.Log("Nurse");
    }
}

class Dog:Mammal
{
	public void Bark()
	{
		Debug.Log("Bark");
	}
}
class Cat : Mammal
{
	public void Meow()
	{
		Debug.Log("Meow");
	}
}