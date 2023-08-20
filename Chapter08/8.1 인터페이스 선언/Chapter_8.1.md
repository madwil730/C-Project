# 8-1 인터페이스의 선언
* 메소드, 이벤트,프로퍼티만 가질 수 없으면 접근제한 한정자를 사용할 수 없고 모든 데이터가 public으로 선언된다
* 인터페이스는 인스턴스를 만들 수 없다
* 인터페이스를 상속받는 클래스는 인스턴스를 만들 수 있으면 인터페이스에 선언된 모든 메소드를 구현해줘야한다(메소드들은 public으로 수식된다)



 ```
인터페이스 예시)

interface ILogger
{
  void WriteLog(string message);
}

class Test : ILogger
{
  public void WriteLog(string message)
  {
     Debug.Log(message);
  }
}


Class InterfaceTest
{
   Start()
  {
     ILogger logger = new Test();
     logger.WriteLog("Hello");
  }

}


```



