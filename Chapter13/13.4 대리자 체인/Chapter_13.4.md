# 13.4 대리자 체인
* 대리자는 여러개의 메소드를 동시에 참조할 수 있다
* += ,-= 을 통해 메소드 여러개를 참조하거나 참조를 끊을 수 있다

```
예시)

delegate void deleTest();

void CallA()
{
   debug.log("Call A");
}

void CallB()
{
   debug.log("Call B");
}


void Start()
{
  deleTest test = new deleTest(CallA);
  test += new deleTest(CallB);

  test(); //Call A, Call B

}



```
