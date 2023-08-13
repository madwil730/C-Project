# 7-11 메소드 숨기기

* 부모 클래스에서 구현된 버전의 메소드를 감추고 자식 클래스에서 구현된 버전만 보여주는 것
* 자식 클래스 버전읜 메소드를 new 한정자로 수식할 수 있다(생성자를 호출할 때 사용하는 new 연산자와는 다른 한정자인다)
* 메소드 숨기기는 오버라이딩과 달라서 객체의 다형성을 표현하지 못한다
```
사용 예)
Class Base
{
  public void MyMethod()
  {
     Debug.Log("Base.MyMethod()");
  }
}

Class Derived : Base
{
  public new void MyMethod() // Base.MyMethod()를 감추고 Derived 클래스에서 구현된 MyMethod()만 노출
  {
     Debug.Log("Derived.MyMethod()");
  }
}

Start()
{
   Derived derived = new Derived();
   derived.MyMethod(); //derived.MyMethod() 출력

   Base baseOrDerived = new Derived();
   baseOrDerived.MyMethod(); //Base.MyMethod() 출력

}

```
