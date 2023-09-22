# 12.6 사용자 정의 예외 클래스 만들기
* Exception 클래스를 상속해서 새로운 예외 클래스를 만들 수 있다

```
예시)
class InvaildArgumentException : Exception
{
    public InvaildArgumentException()
    {
        //...
    }

    public InvaildArgumentException(string message) : base(message)
    {
        //...
    }

}
```
