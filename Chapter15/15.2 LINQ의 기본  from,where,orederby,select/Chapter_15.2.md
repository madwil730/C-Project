# 15.2 LINQ의 기본  from,where,orederby,select
### from
* LINQ 쿼리식은 반드시 from 절로 시작
* from은 IEnumerable<T> 인터페이스를 상속받은 데이터여야 사용 가능하다

### where
* from 절이 데이터 원본으로부터 뽑아낸 범위 변수가 가져야 하는 조건을 where 연산자로 통해 제한 할 수 있다

### orederby
* 데이터를 오름차순으로 정렬한다
* ascending 키워드를 통해 데이터를 내림차순으로 정렬한다

### select
* 최종결과를 추출하는 형식
