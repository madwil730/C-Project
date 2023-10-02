# 13.7 대리자와 이벤트
* 이벤트가 선언되면 해당 변수를 외부에서 호출이 불가능하다
* 대리자는 public, internal로 수식되면 외부에서 호출이 가능하다

```
예시)

class MyNotifier
{
  public event EvnetHandler SomethingHappend;
}

class MainApp
{

  void Start()
  {
      MyNotifier notifer = new MyNotifier();
      notifer.SomethingHappend("aaa"); // 이벤트로 선언되어 에러 발생

  }

}


```
  
  
