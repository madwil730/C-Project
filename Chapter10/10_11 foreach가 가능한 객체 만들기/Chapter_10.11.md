# 10_11 foreach가 가능한 객체 만들기
* foreach 구문은 IEnumerable을 상속하는 형식에만 지원
* IEnumerable 인터페이스를 상속받으면 foreach을 이용하여 반복문을 돌릴 수 있다


### IEnumerable
* Ienumerator GetEnumerator() : Ienumerator 형식의 객체를 반환
* GetEnumerator() 는 Ienumerator 인터페이스를 상속받는 클래스의 객체를 반환해야 한다
* yield 문을 사용하면 Ienumerator를 상속하는 클래스를 따로 구현하지 않아도 컴파일러가 자동으로 처리해준다

### Ienumerator
* boolean Movenext() :  다음 요소로 이동, 컬렉션의 끝을 지난 경우에는 false, 이동이 성공한 경우에는 true를 반환
* void Reset() :  컬렉션의 첫 번째 위치의 앞으로 이동 , 첫 번째 위치가 0번인 경우 Reset()을 호출하면 -1 번으로 이동
* Object Current{get;} : 컬렉션의 현재 요소를 반환 




