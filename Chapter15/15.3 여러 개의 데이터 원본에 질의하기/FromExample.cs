using System.Linq;
using UnityEngine;

class Class
{
	public string Name { get; set; }
	public int[] Score { get; set; }
}

public class FromExample : MonoBehaviour
{
	void Start()
	{
		Class[] arrClass =
		{
			new Class(){ Name = "aaa", Score  = new int[]{ 99,80,70,24} },
			new Class(){ Name = "bbb", Score  = new int[]{ 60,45,87,72}},
			new Class(){ Name = "ccc", Score = new int[] { 92, 30, 85, 94 }},
			new Class(){ Name = "ddd", Score = new int[] { 90, 88, 0, 17 }}
		};

		var classes = from c in arrClass
					  from s in c.Score
					  where s < 60
					  orderby s
					  select new { c.Name, Lowest = s };
				

		foreach (var c in classes)
			Debug.Log(c.Name + " " + c.Lowest); 

	}


}
