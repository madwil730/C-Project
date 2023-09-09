# 10.10 인덱서 
* 인덱스를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티

```
예시)
     class MyList
    {

        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Debug.Log(array.Length);
                }
            }
        }
    }

```




