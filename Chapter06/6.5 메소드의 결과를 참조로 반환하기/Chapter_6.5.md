# 6-5 메소드의 결과를 참조로 반환하기
* 참조 반환값을 이용하여 호출자로 하여금 반환받은 결과를 참조로 다룰 수 있다
* 호출자가 ref 키워드를 사용하지 않는 한 값으로 반환하는 평범한 메소드로 동작된다 
  
```
사용예)

int SomeValue= 10;

public ref int SoMehod()
{
  return ref SomeValue;
}

```








