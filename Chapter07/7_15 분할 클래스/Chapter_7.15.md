# 7-14 중첩 클래스
* 클래스 안에 선언된 클래스를 뜻한다
* 자신이 소속된 클래스의 멤버에 자유롭게 접근 가능하다(해당 멤버가 private여도 접근이 가능하다)
```
사용 예)
Class OuterClass
{
  private int OuterMember; 

  Class MestedClass
  {
      public void DoSomeThing()
      {
         OuterClass outer = new OuterClass();
         outer.OuterMember = 10; 
      }
  }
}

```