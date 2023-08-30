# 9.9 추상 클래스의 프로퍼티
* 추상클래스도 프로퍼티를 사용할 수 있으면 상속 받는 자식 클래스는 추상 프로퍼티를 상속받는다
* 인터페이스와 다르게  구현된 프로퍼티와 구현되지 않은 프로퍼티를 가질수 있디
* 추상 프로퍼티는 abstract 한정자를 이용해서 선언한다
```
예시)
abstract class Product
{
    public string SerialID
    {
        get { return "HI"; }
    }

    abstract public string ProductDate
    {
        get; set;
    }
}

class Test : Productss
{
	public override string ProductDate
    {
        get;
        set;
    }
}


```




