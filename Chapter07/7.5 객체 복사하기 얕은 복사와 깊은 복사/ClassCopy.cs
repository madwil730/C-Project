using UnityEngine;

public class ClassCopy : MonoBehaviour
{
	class MyClass
	{
		public int MyField1;
		public int MyField2;

		public MyClass DeepCopy()
		{
			MyClass newCopy = new MyClass();
			newCopy.MyField1 = MyField1;
			newCopy.MyField2 = MyField2;

			return newCopy;
		}
	}

	void Start()
	{
		//Shallow Copy
		{
			MyClass soure = new MyClass();
			soure.MyField1 = 10;
			soure.MyField2 = 20;

			MyClass target = soure;
			target.MyField2 = 30;

			Debug.Log($"{soure.MyField1} {soure.MyField2}");
			Debug.Log($"{target.MyField1} {target.MyField2}");

		}

		//Deep Copy
		{
			MyClass soure = new MyClass();
			soure.MyField1 = 10;
			soure.MyField2 = 20;

			MyClass target = soure.DeepCopy();
			target.MyField2 = 30;

			Debug.Log($"{soure.MyField1} {soure.MyField2}");
			Debug.Log($"{target.MyField1} {target.MyField2}");
		}
	}
}
