# 6-11 로컬 함수
* 메소드 안에서 선언되고, 선언된 메소드 안에서만 사용되는 함수
* 로컬 함수는 자신이 존재하는 지역에 선언되어 있는 변수를 사용할 수 있다
  
```
사용예)
public void SomeMethod()
{
  int Count = 0;

  SomeLocalFunction(); // 로컬 함수 호출

  void SomeLocalFunction()
  {
  Debug.Log(++Count); // 로컬 함수는 자신이 속한 메소드의 지역 변수를 사용할 수 있다
  }
}

```
