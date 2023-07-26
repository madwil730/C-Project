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
        Debug.Log($"°ª : {price}");
    }
}
public class RefReturnExample : MonoBehaviour
{
    void Start()
    {
        Product product = new Product();    
        ref int ref_local_price = ref product.GetPrice();
        int normal_local_price = product.GetPrice();

        product.PrintPrice();
        Debug.Log($"Ref Local Price : {ref_local_price}");
        Debug.Log($"Normal Local Price : {normal_local_price}");

        ref_local_price = 200;

		product.PrintPrice();
		Debug.Log($"Ref Local Price : {ref_local_price}");
		Debug.Log($"Normal Local Price : {normal_local_price}");


	}

 
}
