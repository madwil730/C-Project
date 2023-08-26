# 9.4 프로퍼티와 생성자
* 객체 생성시 프로퍼티를 초기화 할 수 있다(원하는 프로퍼티만 골라서 초기화 할 수 있다)
```
예시)
Class MyClass
{
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

   public String MyField2
  {
    get
    {
       return MyField2; // myField 의 값을 가져올 수 있다
    }
    set
    {
       MyField2  = value; // myField의 값을 세팅할 수 있다
    }
  }
}

Class StartClass
{
  void Start()
  {
      MyClass myClass = new MyClass
      {
         MyField = 3;
      }
  }
}


```

