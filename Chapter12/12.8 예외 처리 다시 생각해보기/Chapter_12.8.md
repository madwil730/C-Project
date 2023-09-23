# 12.8 예외 처리 다시 생각해보기
* 예외처리를 통해 코드를 간결하게 만들어 줄 수 있다
* StrackTrace 프로퍼티를 통해 문제가 발생한 소스코드 위치를 알려줄 수 있다
   
```
예시)

try
{
    int a = 1;
    Debug.Log(3 / --a);
}
catch (DivideByZeroException e)
{
    Debug.Log(e.StackTrace); //	Debug.Log(3 / --a); 문구를 가리킴
}


```

