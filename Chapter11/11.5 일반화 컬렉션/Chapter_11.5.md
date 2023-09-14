# 11.4 형식 매개변수 제약시키기
* where을 이용하여 형식 매개변수 T에 제약을 줄 수 있다

### 형식 매개변수 제약 표
* where T : struct => T는 값 형식이어야 한다
* where T : class => T는 참조 형식이어야 한다
* where T : new() => T는 반드시 매개변수가 없는 생성자여야 한다
* where T : 기반 클래스 => T는 명시한 기반 클래스의 파생 클래스여야 한다
* where T : 인터페이스 => T는 명시한 인터페이스를 반드시 구현해야 한다
* where T : U => T 는 또 다른 형식 매개변수 U로부터 상속받은 클래스여야 한다
  
```
예시)

class StructArray<T> where T : struct // 값형식만 받게됨
{
    public T[] Array { get; set; }
    public StructArray(int size)
    {
        Array = new T[size];
    }
}



```

