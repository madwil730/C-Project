# 9.5 초기화 전용 자동 구현 프로퍼티
* 프로퍼티를 활용하여 메소드를 선언하지 않고 쉽게 private 변수에 접근할 수 있다
* get 접근자는 필드로부터 값을 읽어오고 set 접근자는 필드에 값을 할당한다
```
예시)
Class MyClass
{
  private int myField;

  public int MyField
  {
    get
    {
       return myField; // myField 의 값을 가져올 수 있다
    }
    set
    {
       myField  = value; // myField의 값을 세팅할 수 있다
    }

  }

}


```

