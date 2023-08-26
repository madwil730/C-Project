# 7-13 읽기 전용 필드
* readonly키워드를 사용하며 읽기만 가능하고 값을 변경할 수 없는 필드를 뜻한다
* 클래스나 구조체의 멤버로만 존재할 수 있다
```
사용 예)
Class Base
{
  private readonly int A; // 다른 곳에서 호출할 시  값만 읽을 수 있다

  public Base(int num)
  {
     A = num;
  }
}

```
