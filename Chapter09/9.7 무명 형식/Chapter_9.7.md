# 9.6 레코드 형식으로 만드는 불변 객체
* 불변 객체는 내부 데이터를 변경할 수 없는 객체를 뜻한다
* 레코드는 값 형식처럼 다룰 수 있는 불변 참조 형식을 뜻한다
* 레코드를 선언할때 record 키워드와 초기화 전용 자동 구현 프로퍼티를 구현해야 한다
* with 키워드를 사용하여 복사 생성자를 작성할 수 있다
```
record 선언 예시)

public record Transaction
{
	public string From { get; init; }
	public string To { get; init; }
}

public class RecordExample : MonoBehaviour
{

	void Start()
	{
		Transaction transaction = new Transaction()
		{
			From = "Alice",
			To = "BoB"
	
		};

		Transaction transaction2 = transaction with { To = "Tom" };
		Debug.Log(transaction); // Transaction { From = Alice, To = BoB }
		Debug.Log(transaction2); // Transaction { From = Alice, To = Tom }
	}
}
```




