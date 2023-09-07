# 10.8 컬렉션 맛보기
* 컬레션은 같은 성격을 띈 데이터의 모음을 담은 자료구조

### ArrayList
* 배열과 닮은 컬렉션, 컬렉션의 요소에 접근할 때는 []연산자 사용
* 배열과 달리 컬렉션을 생성할 때 용량을 미리 지정할 필요 없이 자동으로 용량이 늘거나 줄어듬
```
예시)
    ArrayList list = new ArrayList();
    list.Add(10);
    list.Add(20);
    list.Add(30);

    list.RemoveAt(1); // 20을 삭제

    list.Insert(1, 25); // 25를 번 잉ㄴ덱스에 삭입 , 즉 10 과 30 사이에 25를 삽입

```

### Queue
* 먼저 추가된 데이터가 먼저 출력 처리되는(FIFO, First In First Out) 자료 구조
* Queue는 맨 뒤에 데이타를 계속 추가하고, 맨 앞에서만 데이타를 읽기 때문에 순차적으로 데이타를 처리하게 된다
```
예시)

    Queue que = new Queue();
    que.Enqueue(1);
    que.Enqueue(2);
    que.Enqueue(3);

    while(que.Count >0)
       Debug.Log(que.Dequeue());	 // 1 2 3

```

### Stack
* 가장 나중에 추가된 데이타가 먼저 출력 처리되는(LIFO, Last In First Out) 자료 구조
* 스택은 개념적으로 한 쪽 끝에서만 자료를 넣거나 뺄 수 있는 구조로 되어 있다
```
예시)

    Stack stack = new Stack();	
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);

    while (stack.Count > 0)
      Debug.Log(stack.Pop());    // 3 2 1

```

### Hashtable
*  Hashtable은 "Key-Value" 구조를 가지는 컬렉션
* 키(Key)는 데이터를 식별하기 위해 필요한 정보를 가지며, Hashtable에서 키는 모든 데이터 타입이 될 수 있다
* (Value)은 키에 매핑되는 데이터
* 매우 빠른 탐색 속도를 가짐
```
예시)
    Hashtable hashtable = new Hashtable();
    hashtable["하나"] = 1;
    hashtable["둘"] = 2;
    hashtable["셋"] = 3;

    Debug.Log(hashtable["하나"]); //1
    Debug.Log(hashtable["둘"]); //2
    Debug.Log(hashtable["셋"]); //3

```



