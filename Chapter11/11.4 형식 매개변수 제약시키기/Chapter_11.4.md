# 11.3 일반화 클래스
* 일반화 클래스는 데이터 형식을 일반화한 클래스
  
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

