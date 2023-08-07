# 7-6 this 키워드 
* 객체가 자신을 지칭할 때 사용하는 키워드
* 객체 내부에서 자신의 필드나 메소드에 접근할때 this 키워드를 사용 
```
사용 예)
Class Employee
{
  private string Name;

  public void SetName(string Name)
  {
      this.Name = Name; // this 키워드를 사용해  Employee의 변수 Name에 접근가능
  }
}


```

* this() 를 통해 자기 자신의 생성자를 가르킬 수 있다 
