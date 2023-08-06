# 7-4 정적 필드와 메소드 
* Static 한정자를 사용해 메소드나 필드를 객체의 생성없이 호출 할 수 있다
* Staitc 한정자는 클래스가 처음으로 사용될 때 한번 초기화 되어 계속 동일한 메모리를 사용하게 된다
 ```
class Statictest
{
    public static int a;

    public static void CallA()
    {
        Debug.Log(a);
    }
}

public class etcTest : MonoBehaviour
{
	void Start()
    {
      Statictest.a = 3;   // 객체 생성 없이 호출할 수 있다
		Statictest.CallA();  // 3
	}
}

```

