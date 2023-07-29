
# 6-8 가변 개수의 인수
* 매개변수의 개수가 유연하게 변할 수 있는 인수를 뜻한다
* params 키워드와 배열을 이영해서 선언
  
```
사용예)

int Sum(params int[] args)
{
    int sum= 0;

    for(int i= 0; i < args.Length; i++)
        sum += args[i];

    return sum;
}

void Start
{
    int total =0;
    total = Sum(1,2); //3
    total = Sum(1,2,3); // 6
    total = Sum(1,2,3,4);  //10
}

```

