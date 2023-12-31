# 20.1 네트워크 프로그래밍에 앞서 알아둬야 할 기초
### TCP/IP 스택
* 프로토콜 : 컴퓨터들이 네트워크를 통해 데이터를 주고받기 위한 통신 규약
* TCP/IP : 인터넷 표준 프로토콜로 애플리케이션 계층, 전송 계층, 인터넷 계층, 링크 계층 으로 구성 되어 있다
  
#### 링크 계층
* 네트워크의 물리적인 연결 매체를 통해 패킷을 주고받는 작업을 담당한다
* 패킷에서 물리적 데이터 전송에 사용되던 부분을 제거하고 인터넷 계층에 넘긴다
  
 #### 인터넷 계층
* 패킷을 수신해야 할 상대의 주소를 지정하고 나가는 패킷에 대해서는 적절한 크기로 분할하며 들어오는 패킷에 대해서는 재조립을 수행한다
* 해당 계층에서 사용되는 규약이 인터넷 프로토콜 즉 IP다
* 해당 계층에서 사용하는 주소 체계가 IP 주소이다
  
#### 전송 계층
* 패킷의 운송을 담당하는 프로토콜이 정의되어 있다
* 해당 계층에서 사용되는 규약이 TCP다
* TCP는 IP가 제공하지 않는 연결성, 신뢰성을 제공한다
  
#### 애플리케이션 계층
* 각 응요 프로그램의 프로토콜이 정의되는 곳이다
* HTTP,FTP,SNMP 등이 애플리케이션 계층에서 정의된 프로토콜의 대표적인 예시다


### TCP/IP의 주소 체계  :  IP 주소
* IP 주소: 인터넷에서 패킷을 배달하는데 사용하는 주소
* IPv6 : 주소 길이가 128비트에 이르며 16비트의 수 8개를 : 으로 연결한다

### 포트
* 패킷이 드나드는 출입구
* 부호가 없는 16비트 정수로 0~65535 사이의 값을 이용한다

### TCP/IP의 동작 과정
* TCP/IP는 서버/클라이언트 방식으로 동작한다
* 서버가 먼저 서비스를 시작하고 클라이언트가 서버에 접속한다
* 서버와 클라이언트는 서로 데이터를 주고받을 수 있다
* 종료 요청은 클라이언트 나 서버에서 할 수 있다

  

