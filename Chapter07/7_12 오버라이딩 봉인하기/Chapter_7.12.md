# 7-12 오버라이딩 봉인하기
* 메소그를 오버라이딩 되지 않도록 sealed 키워드를 이용하여 봉인할 수 있다
* 메소드를 봉인할 수 있는 것은 virtual로 선언된 가상 메소드를 오버라이딩한 버전의 메소드만 가능
* 메소드를 봉인하면 해당 메소드를 오버라이딩 하여 재정의 할 수 없다
```
사용 예)
Class Base
{
  public virtual void MyMethod()
  {
     //....
  }
}

Class Derived : Base
{
  public sealed override void SealMe() // 해당 메서드는 봉인되어 자식 클래스에서 해당 메서드를 재정의할 수 없다
  {
    //...
  }
}



```
