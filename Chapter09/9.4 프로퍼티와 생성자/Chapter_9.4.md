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
       return myField; 
    }
    set
    {
       myField  = value; 
    }
  }

   public String MyField2
  {
    get
    {
       return MyField2; 
    }
    set
    {
       MyField2  = value; 
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

