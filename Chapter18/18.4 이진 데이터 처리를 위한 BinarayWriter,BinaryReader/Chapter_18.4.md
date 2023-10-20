# 18.4 이진 데이터 처리를 위한 BinarayWriter,BinaryReader
* BinarayWriter는 스트림에 이진 데이터를 기록하기 위한 목적으로 사용한다
* BinaryReader 스트림에 이진 데이터를 읽기 위한 목적으로 사용한다
* BinarayWriter,BinaryReader 사용하여 
```
예시)
void Start()
{
    using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
   {
      bw.Write(int.MaxValue);
      bw.Write("Good moring");
      bw.Write(uint.MaxValue);
   }

   using (BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open)))
   {
      br.ReadInt32();
      br.ReadString();
      br.ReadUInt32();
   }
}


```
