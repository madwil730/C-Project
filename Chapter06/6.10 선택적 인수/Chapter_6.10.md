
# 6-10 선택적 인수
* 매소드의 매개변수를 특정 값으로 초기화 할 수 있다
* 기본값을 가진 매개변수는 메소드를 호출할 때 해당 인수를 생략 할 수 있다
  
```
사용예)

void Start()
{
  Debug.log(Sum(5)) // 8
  Debug.log(Sum(5,5)) // 10
}


int Sum(int a, int b = 3)
{
    int sum= a+b;

    return sum;
}

```
