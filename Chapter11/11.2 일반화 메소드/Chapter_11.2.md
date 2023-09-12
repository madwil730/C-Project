# 11.2 일반화 메소드
* 일반화 메소드는 데이터 형식을 일반화한 메소드
  
```
일반화 예시)
{
   void CopyArray<T>(T[] source, T[] target)
	{
		for(int i = 0; i < source.Length; i++)
			target[i] = source[i];	
	}


```

