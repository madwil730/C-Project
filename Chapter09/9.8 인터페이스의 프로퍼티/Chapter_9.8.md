# 9.8 인터페이스의 프로퍼티
* 인터페이스는 프로퍼티를 가질 수 있다
* 인터페이스를 상속하는 클래스는 반드시 해당 프로퍼티를 구현해야한다

```
예시)

interface IProduct
{
    string ProductName
    {
        get;
        set;
    }
}

class Products: IProduct
{
    private string productName;
	public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }
}


```




