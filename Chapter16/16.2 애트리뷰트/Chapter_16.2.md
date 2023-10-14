# 16.2 애트리뷰트
* 애트리뷰트는 코드에 대한 부가 정보를 기록하고 읽을 수 있는 기능
* 메소드 위에[] 를 넣어 애트리뷰트 기능을 사용한다
```
예시)
  [Obsolete("해당 메소드는 폐기됨")]
    public void OldMethod()
    {

        Debug.Log("old"); // 호출시 "해당 메소드는 폐기됨 경고" 문자 뜸
	}
```
### 호출자 정보 애트리뷰트
* 애트리뷰트를 사용하여 호출자 정보를 알 수 있다
* [CallerMemberName] : 현재 메소드를 호출한 메소드 또는 프로퍼티의 이름을 나타냄
* [CallerFilePathAttribute] : 현재 메소드가 호출된 소스 파일 경로를 나타냄
* [CallerLineNumberAttribute] : 현재 메소드가 호출된 소스 파일의 행 번호를 나타냄

### 내가 만드는 애트리뷰트 
* System.Attribute 클래스를 상속받아 자신이 원하는 애트리 뷰트를 생성할 수 있다
