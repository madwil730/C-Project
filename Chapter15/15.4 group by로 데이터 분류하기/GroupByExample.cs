using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
class Profile
{
	public string Name { get; set; }
	public int Height { get; set; }
}

public class GroupByExample : MonoBehaviour
{
	void Start()
	{
		Profile[] arrProfile =
		{
			new Profile(){ Name = "aaa", Height =186},

			new Profile(){ Name = "bbb", Height =158},
			new Profile(){ Name = "ccc", Height =172},
			new Profile(){ Name = "ddd", Height =178},
			new Profile(){ Name = "eee", Height =171}
		};

		var listProfile = from profile in arrProfile
					   orderby profile.Height
					   group profile by profile.Height < 175 into g
					   select new
					   {
						   GroupKey = g.Key,
						   Profiles = g
					   };

		foreach (var Group in listProfile)
		{
			Debug.Log(" 175 ¹Ì¾ÈÀº" + Group.GroupKey); 
			foreach(var profile in Group.Profiles)
			{
				Debug.Log(profile.Name + " " + profile.Height);
			}
		}

	}


}