# 6-4 참조에 의한 매개변수 전달
* ref 키워드를 사용하여 매개변수를 참조에 의한 전달로 사용할 수 있다
* 참조에 의한 전달은 매개변수가 참조하고 있는 원본 변수에 수정이 이루어진다
  

```
사용 예)
void Swap(int a, int b)
{
    int temp = b;
    b = a;
    a = temp;
}


Start()
{
  int x = 3;
  int y = 4;
  Debug.Log(x); //3 
  Debug.Log(y); //4

  Swap(ref x, ref y); // ref 키워드를 사용하여 매개변수가 참조하고 있는 원본 변수에 수정이 이루어진다

  Debug.Log(x); //4 
  Debug.Log(y); //3  
}
```








