# 10.5 2차원 배열
* 2차원 배열은 1차원 배열을 원소로 갖는 배열

```
예시)

void Start()
{
  int [ , ] array = new int [2,3]
  array [0,0] =1;
  array [0,1] =2;
  array [0,2] =3;
  array [1,0] =4;
  array [2,1] =5;
  array [3,2] =6;

  Debug.Log(array[0,2]) //3;

  // 2차원 배열 초기화 방법
  int[,] arr = new int[2,3] {{1,2,3},{4,5,6}};
  int[,] arr2 = new int[,] {{1,2,3},{4,5,6}};
  int[,] arr3 = {{1,2,3},{4,5,6}};

}

```



