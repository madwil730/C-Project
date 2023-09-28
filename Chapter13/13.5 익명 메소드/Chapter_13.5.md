# 13.5 익명 메소드
* 익명 메소드 : 이름이 없는 메소드를 뜻한다

  
  
```
예시)
delegate int Calculate(int a, int b);

	private void Start()
	{
		Calculate Calc;

		Calc = delegate (int a, int b)  // 익명 메소드
		{
			return a + b;
		};

		Debug.Log(Calc(3, 4)); // 7 
	
	}
```
