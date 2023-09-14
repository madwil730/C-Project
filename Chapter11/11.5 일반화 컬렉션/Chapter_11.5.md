# 11.5 일반화 컬렉션
* 컬렉션은 object 형식에 기반하고 있기 때문에 요소에 접근할 때마다 형식변환을 한다
* 일반화 컬렉션은 일반화에 기반해서 만들어졌기 때문에 쓸데없는 형식 변환이 일어나지 않는다


### List
```
예시)
    List<int> list = new List<int>();
    list.Add(10);
    list.Add(20);
    list.Add(30);

```

### Queue<T>
```
예시)

    Queue que<int> = new Queue<int>();
    que.Enqueue(1);
    que.Enqueue(2);
    que.Enqueue(3);

    while(que.Count >0)
       Debug.Log(que.Dequeue());	 // 1 2 3

```

### Stack<T>
```
예시)

    Stack<int> stack = new Stack<int>();	
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);

    while (stack.Count > 0)
      Debug.Log(stack.Pop());    // 3 2 1

```

### Dictionary<TKey,TValue>
*  Hashtable은 일반화 버전
```
예시)
    Dictionary<string,int> dic = new Dictionary<string,int>();
    dic["하나"] = 1;
    dic["둘"] = 2;
    dic["셋"] = 3;

    Debug.Log(dic["하나"]); //1
    Debug.Log(dic["둘"]); //2
    Debug.Log(dic["셋"]); //3

```


