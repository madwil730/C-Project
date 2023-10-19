# 18.3 실수를 줄여주는 using 선언
* using을 활용하여 자동으로 Dispose 메소드가 호출되게 코드를 짤 수 있다
* using은 Stream 객체뿐 아니라 IDispose를 상속해서 Dispose 매소드를 구현하는 모든 객체에 대해 사용할 수 있다
```
예시)

using (Stream AStream = new FileStream("a.dat", FileMode.Create))
{
		    byte[] wBytes = BitConverter.GetBytes(someValue);
			outStream.Write(wBytes, 0, wBytes.Length); // 변환한  byte 배열을 파일 스트림을 통해 파일에 기록
}// 코드 블록이 끝나면서 AStream.Dispose()호출


```
