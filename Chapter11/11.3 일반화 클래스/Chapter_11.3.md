# 11.3 일반화 클래스
* 일반화 클래스는 데이터 형식을 일반화한 클래스
  
```
일반화 예시)
{
   void CopyArray<T>(T[] source, T[] target)
	{
		for(int i = 0; i < source.Length; i++)
			target[i] = source[i];	
	}


```

