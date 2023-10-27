# 19.2 Task와 Task(TResult) 그리고 Parallel
### Task 클래스
* Task 클래스를 통해 비동기 코드를 처리 할 수 있다
* 동기 코드 : 메소드를 호출한 뒤에 해당 메소드의 실행이 완전히 종료되어야만(즉 반환되어야만) 다음 메소드를 호출 할 수 있다
* 비동기 코드 : 메소드를 호출한 뒤에 메소드의 종료를 기다리지 않고 바로 다음 코드를 실행한다
* Task클래스는 인스턴스를 생성할 때 Action 대리자를 넘겨받는다
### 비동기 실행결과를 주는 Task<TResult> 클래스
* Task<TResult>는  코드의 비동기 실행 결과를 손쉽게 취합할 수 있도록 도와준다
* Action 대리자를 받는 대신 Func 대리자를 받는다
```
예시)
        var myTask = Task<List<int>>.Run(() =>
        {
            Thread.Sleep(1000);

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            list.Add(5);

            return list;    // TResilt 형식의 결과를 반환
        });

        var myList = new List<int>();
        myList.Add(0);
        myList.Add(1);
        myList.Add(2);

        myTask.Wait();
        myList.AddRange(myTask.Result.ToArray()); // myList의 요소는 0,1,2,3,4,5 가 된다 

```
