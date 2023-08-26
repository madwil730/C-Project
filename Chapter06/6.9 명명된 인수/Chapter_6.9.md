
# 6-9 명명된 인수

* C#의 기능중 하나, 메소드를 호출할 때 인수의 이름에 근거해서 데이터를 할당할 수 있는 기능
* 메소드를 호출할 때만 인수의 이름뒤에 콜론(:)을 붙이면 된다


```
사용예)

 void printProfile(string name, string phone)
{
    Debug.Log($"name: {name}, phone: {phone}");
}

void Start()
{
    printProfile(phone: "010-2222-3333", name: "박찬호"); // name: 박찬호, phone: 010-2222-3333
}

```
