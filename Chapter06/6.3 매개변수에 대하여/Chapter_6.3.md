# 6-2 return
* 점프문의 한 종류로 프로그램의 흐름을 호출자에게 돌려놓는다

```
사용 예)
int returnTest(int n)
{
  if(n < 2)
     return n; // n이 2보다 작은면 n을 돌려줌
  else
     return n+2; // n이 2보다 크면 n+2 을 돌려줌

}
```

```
사용 예)
void returnTest(int n)
{
  if(n == 2)
     Debug.log("n은 2이다")
     return; // 반환형식이 void 여서 return을 쓰면 아무 결과도 반환하지 않는다
  else
      Debug.log("n은 2가 아닌다")

}
```







