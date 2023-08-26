# 9-1 public 필드의 유혹
* get/set 메소드를 활용하여 private 필드를 가진 값에도 접근을 할 수 있다ㅡ
```
예시)
Class MyClass
{
  private int MyField;
  public int GetMyField() { return myFieldl; }
  public void SetMyField {int Newvalue} {myField = new Value;}
}


```

