# 12.5 try~catch와 finally
* finally 문 안에 있는 코드는 예외가 실행되도 코드가 컴파일 된다
* return, throw 문을 만나도 finally 문안에 있는 코드는 무조건 실행된다


```
예시)

	public void  Deiveid(int a, int b)
	{
		try
		{
			var result = a / b;
		}
		catch (DivideByZeroException e)
		{
			Debug.Log(e);
		}
		finally
		{
			Debug.Log("deiveid 종료");
		}

	}

```
