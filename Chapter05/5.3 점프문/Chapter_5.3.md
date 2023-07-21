# 5-3 점프문
### break
* 현재 실행 중인 반복문이나 switch 문의 실행을 중단하고자 할 때 사용한다
```
사용 예)
int i = 0;
while( i > =0 )
{
  if(i == 10)
    break;    // i 가 10이면 while 종료

  debug.log(i++)
}


```

### continue
* 반복문을 한 회 건너 뛰어 반복을 수행하게 하는 구문
```
사용 예)
for(int i = 0; i< 5; i++)
  continue; // i가 3인 경우 현재 실행중인 반복을 건너뛴다

Debug.log(i); 
```

### goto
* 표시한 곳으로 코드를 뛰어넘는다

```
사용 예)
Debug.log(1); // 1출력

goto JUMP;  // 표시한 곳으로 코드를 건너뜀
Debug.log(2); // 코드가 건너뛰게 되어 2 미출력

JUMP:
Debug.log(3); // 3출력


```



