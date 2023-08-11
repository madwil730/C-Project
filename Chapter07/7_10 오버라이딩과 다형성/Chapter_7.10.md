# 7-9 기반 클래스와 파생 클래스 사이의 형식 변환, 그리고 is 와 as

* 자식 클래스의 인스턴스는 부모 클래스의 인스턴스로 사용할 수 있다
```
형변환 예시)
Class Mammal
{
  public void Nurse()
  {
     //Nurse 메소드 설명
  }
}

Class Dog : Mammal
{
  public void Bark()
  {
     //Bark 메소드 설명
  }
}

Start()
{
   Mammal mammal = new Mammal();
   mammal.Nurse();

   mammal = new Dog();
   mammal.Nuse();

  Dog dog =(Dog)mammal;
  dog.Nurse()
  dog.Bark();
}
```

### is
* 객체가 해당 형식에 해당하는지 검사하여 그 결과를 bool 값으로 반환한다
  
### as
* 형식 변환 연산자의 역활을 하며 형식 변환에 실패하면 객체 잠조를 null로 만든다
  


