using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;

class Profile
{
    public string Name;
    public int Height;
}

class Product
{
    public string Title;
    public string Star;
}
public class JoinExample : MonoBehaviour
{
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

	    Product[] arrProduct =
	   {
			new Product(){ Title = "��", Star = "aaa"},
			new Product(){ Title = "����", Star = "bbb"},
			new Product(){ Title = "�ϸ�", Star = "bbb"},
			new Product(){ Title = "��", Star = "ccc"},
			new Product(){ Title = "�����", Star = "ddd"}
		};

        //���� ����
        var listProfile =
            from profile in arrProfile
            join product in arrProduct on profile.Name equals product.Star
            select new
            {
                Name = profile.Name,
                Work = product.Title,
                Height = profile.Height

			};

        Debug.Log("--���� ���� ���--");

        foreach(var profile in listProfile)
        {
            Debug.Log(profile.Name+" "+profile.Work + " " + profile.Height);    
        }

        //�ܺ� ����
		listProfile =
		  from profile in arrProfile
		  join product in arrProduct on profile.Name equals product.Star into ps
          from Product in ps.DefaultIfEmpty(new Product() { Title = "�׷� �� ����"})
		  select new
		  {
			  Name = profile.Name,
			  Work = Product.Title,
			  Height = profile.Height
		  };

		Debug.Log("--�ܺ� ���� ���--");

		foreach (var profile in listProfile)
		{
			Debug.Log(profile.Name + " " + profile.Work + " " + profile.Height);
		}
	}


}
