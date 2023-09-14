using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class StructArray<T> where T : struct
{
    public T[] Array { get; set; }
    public StructArray(int size)
    {
        Array = new T[size];
    }
}

class RefArray<T> where T : class
{
	public T[] Array { get; set; }
	public RefArray(int size)
	{
		Array = new T[size];
	}
}

class Based { }
class Derived2 : Based { }

class BaseArray<U> where U : Based
{
	public U[] Array { get; set; }
	public BaseArray(int size)
	{
		Array = new U[size];
	}

    public void CopyArray<T>(T[]Source) where T : U
    {
        Source.CopyTo(Array, 0);
    }
}

public class WhereExample : MonoBehaviour
{
    public T CreateInstance<T>() where T : new()
    {
        return new T(); 
    }

    void Start()
    {
        StructArray<int> a = new StructArray<int>(3);
        a.Array[0] = 0;
		a.Array[1] = 1;
		a.Array[2] = 2;

        RefArray<StructArray<double>> b  = new RefArray<StructArray<double>>(3);
        b.Array[0] = new StructArray<double>(5);
        b.Array[1] = new StructArray<double>(10);
        b.Array[2] = new StructArray<double>(15);

        BaseArray<Based> c = new BaseArray<Based>(3);
        c.Array[0] = new Based();
        c.Array[1] = new Derived2();
        c.Array[2] = CreateInstance<Based>();

        BaseArray<Derived2> d = new BaseArray<Derived2>(3);
        d.Array[0] = new Derived2();   // based 형식은 여기에 할당할 수 없음
        d.Array[1] = CreateInstance<Derived2>();
        d.Array[2] = CreateInstance<Derived2>();

		BaseArray<Derived2> e = new BaseArray<Derived2>(3);
        e.CopyArray<Derived2>(d.Array);
	}
}
