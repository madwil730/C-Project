# 9.6 레코드 형식으로 만드는 불변 객체
* 불변 객체는 내부 데이터를 변경할 수 없는 객체를 뜻한다
* 레코드는 값 형식처럼 다룰 수 있는 불변 참조 형식을 뜻한다
* 레코드를 선언할때 record 키워드와 초기화 전용 자동 구현 프로퍼티를 구현해야 한다
```
record 선언 예시)

record RecordExample
{
  public string From {get; init;}
}

```


