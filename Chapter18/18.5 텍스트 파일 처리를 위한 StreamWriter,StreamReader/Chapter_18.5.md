# 18.5 텍스트 파일 처리를 위한 StreamWriter,StreamReader
* StreamWriter,StreamReader 를 통해 쉽게 텍스트 파일을 읽을 수 있다

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
