# 4-11 null 병합 연산자
* null 병합 연산자(??)는 변수/객체의 null검사를 간결하게 만든다  
* ?? 연산자는 두개의 피연산자를 받아드링고 왼쪽 피연산자가 null인지 평가한다   
* 왼쪽 피연사자가 null이 아닐경우 왼쪽 피연산자를 반환  
* 왼쪽 피연사자가 null인 경우 오른쪽 피연산자를 반환  



```
사용 예
int?  num = null;
Debug.log(num ?? 0); // 0

num = 99;
Debug.log(num ?? 0); // 99

string str = null;
Debug.log(str ?? "Default"); // Default

str = "string";
Debug.log(str ?? "Default"); // string
```