# 12.4 예외 던지기
* throw 문을 통해 예외를 호출 할 수 있다


```
예시)

    void Start()
    {
        try
        {
            Throw(13);
        }
        catch(Exception e)
        {
            Debug.LogException(e);  // 10 보다 크다
        }
    
    }

    public void Throw(int num)
    {
        if (num < 10)
            Debug.Log("10 아래");
        else
            throw new Exception("10보다 크다");
    }

```
