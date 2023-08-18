# 7-16 확장 메소드
* 기존 클래스의 기능을 확장하는 기법
* static 한정자로 수식해야 하며 첫 번째 매개변수는 반드시 this키워드를 쓴다
* this키워드 다음에 오는 매개변수 목록이 실제로 확장메소드를 호출 할때 입력되는 매개변수이다
```
확장 매개변수 사용 예)

partial static class MyClass
{
   public static int Method(this int MyInt, int exponent)
   {
   //...
   }
}

```
