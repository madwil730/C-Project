# 9.5 초기화 전용 자동 구현 프로퍼티
* init 접근자를 통해 프로퍼티가 초기화 될때만 값을 설정할 수 있다
```
예시)
Class MyClass
{
  public int MyField {get; init;}
}


```

