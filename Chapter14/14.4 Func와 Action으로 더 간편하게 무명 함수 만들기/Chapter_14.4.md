# 14.3 문 형식의 람다식
* => 연산자 뒤에 {}로 둘러쌓인 코드를 선언할 수 있다


```
delegate void Test();

	private void Start()
	{
		Test test = () =>
                {
                    Debug.log(1);
                    Debug.log(2);
                    Debug.log(3);
                }	
	
	}


```
