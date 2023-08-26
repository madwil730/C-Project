using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Product
{
    private int price = 100;

    public ref int GetPrice()
    {
        return ref price;   
    }

    public void PrintPrice()
    {
        Debug.Log($"값 : {price}");
    }
}
public class RefReturnExample : MonoBehaviour
{
    void Start()
    {
        Product product = new Product();    
        ref int ref_local_price = ref product.GetPrice();
        int normal_local_price = product.GetPrice();

        product.PrintPrice(); //100
        Debug.Log($"Ref Local Price : {ref_local_price}"); //100
	Debug.Log($"Normal Local Price : {normal_local_price}"); //100

	ref_local_price = 200;

	product.PrintPrice(); //200
	Debug.Log($"Ref Local Price : {ref_local_price}"); //200
	Debug.Log($"Normal Local Price : {normal_local_price}"); //100, ref키워드를 사용하지 않으니 값이 참조 되지 않고 복사됨


	}

 
}
