# 14.2 처음 만나는 람다식
* 람다식은 익명 메소드를 만들기 위해 사용, 해당 메소드를 무명 함수라고 부른다
* => 연산자를 통해 매개변수를 전달할 수 있다(=> 는 입력 연산자이다)


```
delegate int Calculate(int a, int b);

	private void Start()
	{
		Calculate calc = (a, b) => a + b;
		Debug.Log(calc(3,4)); //7	
	
	}


```
