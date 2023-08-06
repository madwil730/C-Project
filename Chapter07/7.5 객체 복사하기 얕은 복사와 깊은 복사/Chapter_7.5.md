# 7-5 객체 복사하기 얕은 복사와 깊은 복사
* 얕은 복사 : 참조 타입 데이터가 저장한 메모리 주소값을 복사 한 것
* 깊은 복사 : 새로운 메모리 공간을 확보해 완전히 복사하는 것
```
얕은 복사 예시)
class MyClass
{
	public int MyField1;
	public int MyField2;
}

public class CopyTest
{
	private void Start()
	{
		MyClass source = new MyClass();
		source.MyField1 = 10;
		source.MyField2 = 20;

		MyClass target = source;
      // 얕은 복사가 일어남, target은 source의 힙에 있는 객체가 아닌 스택에 있는 참조를 복사하기 때문에
      // source 와 target은 같은 메모리를 바라보게 됨
		target.MyField2 = 30;

		Debug.LogFormat("{0},{1}", source.MyField1, source.MyField2); // 10 ,30 
		Debug.LogFormat("{0},{1}", source.MyField1, target.MyField2); // 10, 30
	}
}

```

* 깊은 복사을 통해 별도의 힙공간에 객체를 보관할 수 있다