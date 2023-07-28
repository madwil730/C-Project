
# 6-7 메소드 오버로딩
* 하나의 메소드 이름에 여러개의 구현을 올리는 것
* 컴파일러가 매개변수의 수와 형식을 구분하여 어떤 메소드가 호출되는지 찾아준다

```
사용예)

int Plus(int a, int b)
{
    return a+b;
}

double Plus(double a, double b)
{
    return a+b;
}

void Start()
{
  int result1 = Plus(1,2);
  double reult2 - Plus(3.1,2.4); // 오버로딩 사용
}

```





