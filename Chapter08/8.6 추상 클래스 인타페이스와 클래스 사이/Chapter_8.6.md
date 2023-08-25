# 8.5 인터페이스의 기본 구현 메소드 
* 인터페이스는 메소드를 정의하여 해당 인터페이스를 상속받는 클래스가 메소드를 오버라이딩 하지 않게 만들 수 있다
* 구현 메소드는 인터페이스 참조로 업캐스팅 했을 때만 사용할 수 있다
```
예시)
interface ILogger
{

  void WriteLog(string message)
  {
     Debug.Log(message);
  }  
}


```

