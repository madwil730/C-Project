# 5-1 분기문 
### if문 
* 한번에 단 하나의 조건은 평가하는 구문
* if 문에서 사용하는 조건식은 bool 형태여야 한다
* 사용 예) if(조건식) 참인 경우에 실행할 코드;

### switch문 
* 조건식의 결과가 가질 수 있는 다양한 경우를 한번에 평가하는 구문
* 조건식의 형식은 정수 와 문자형 형식을 지원한다
* break 문을 통해 switch 문 을 종료 할 수 있다
* When 절을 이용하여 if 문처럼 조건을 걸 수 있다
* 아무 조건도 맞지 않으면 default문을 통해 switch 가 끝난다
```
사용 예)
switch(조건식)
{
  case 상수 1:
    // 실행할 코드
    break;
  case 상수 2 when  조건식 > 0 :
    // 실행할 코드
    break;
  default :
    // 실행할 코드
    break;
}
```
* switch 문은 변수의 조건식으로 표현할 수 있다
* case : 는 => ,default 는 _로 바뀌어서 사용된다

```
bool isbool = true;
string grade = score switch
{
  90 when isbool = true => "B+" // scrore 가 90 이어도 isbool이 true 면 B+
  90 => "A",
  80 => "B",
  70 => "C",
  60 => "D",
  _=> "F",
}

```







