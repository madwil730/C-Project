# 11.4 형식 매개변수 제약시키기
* where을 이용하여 형식 매개변수 T에 제약을 줄 수 있다
  
```
일반화 예시)

class Array_Generic<T>
{
     private T[] array;

     public T getElement(int index) { return array[index]; }	
}

private void Start()
{
     Array_Generic<int> intArr = new Array_Generic<int>();
     Array_Generic<string> strArr = new Array_Generic<string>();
}



```

