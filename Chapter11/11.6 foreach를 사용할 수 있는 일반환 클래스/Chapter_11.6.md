# 11.6 foreach를 사용할 수 있는 일반환 클래스
* IEnumerable<T>를 통해 foreach 문을 형식변환없이 순회가 가능하다


### IEnumerable<T>
* Ienumerator GetEnumerator() : Ienumerator 형식의 객체를 반환(IEnumerable 로 부터 상속받은 메소드)
* Ienumerator<T> GetEnumerator() : IEnumerator<T> 형식의 객체를 반환
* 
### IEnumerator<T>
* boolean Movenext() :  다음 요소로 이동, 컬렉션의 끝을 지난 경우에는 false, 이동이 성공한 경우에는 true를 반환
* void Reset() :  컬렉션의 첫 번째 위치의 앞으로 이동 , 첫 번째 위치가 0번인 경우 Reset()을 호출하면 -1 번으로 이동
* Object Current{get;} : 컬렉션의 현재 요소를 반환
* T Current{get;} : 컬렉션의 현재 요소를 반환


