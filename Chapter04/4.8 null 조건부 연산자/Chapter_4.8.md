# 4-8 null 조건부 연산자 
null 조건부 연산자(?.) 는 객체의 멤버에 접근하기 전에 해당 객체가 null인지 검사하여  
그 결과가 참 이면 null을 반환하고 그렇지 않으면 값을 반환한다





```
== 연산자를 이용한 코드
class Foo
{
  public int member;
}

Foo foo = null;

int? bar;
if(foo = null)
   bar = null;
else
  bar = foo.member;
```

 
```
?. 연산자를 이용한 코드
class Foo
{
  public int member;
}

Foo foo = null;
bar = f00?.member;
```




