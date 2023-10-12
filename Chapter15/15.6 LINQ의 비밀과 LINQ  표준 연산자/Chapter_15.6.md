# 15.6 LINQ의 비밀과 LINQ  표준 연산자
* 컴파일러가 LINQ 쿼리식을 일반적인 메소드 호출 코드로 만들어 컴파일을 진행한다
* MSDN의 표준 연산자를 사용하여 쿼리식을 만들 수 있다

```
예시)
void Start()
    {
		Profile[] arrProfile =
		{
			new Profile(){ Name = "aaa", Height = 111},
			new Profile(){ Name = "bbb", Height = 222},
			new Profile(){ Name = "ccc", Height = 333},
			new Profile(){ Name = "ddd", Height = 444},
			new Profile(){ Name = "eee", Height = 555}
		};

		var profiles = from profile in arrProfile
					   where profile.Height < 180
					   select profile;

		double average = profiles.Average(profile => profile.Height);
	
	}
```
