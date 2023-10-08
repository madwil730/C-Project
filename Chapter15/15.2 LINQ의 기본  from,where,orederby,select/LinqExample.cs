using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


class Profile
{
    public string Name { get; set; }
    public int Height { get; set; }
}

public class LinqExample : MonoBehaviour
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

        var profiles = from profile in arrProfile
                       where profile.Height < 175
                       orderby profile.Height
                       select new
                       {
                           Name = profile.Name,
                           Height = profile.Height +10
                       };

        foreach (var profile in profiles)
            Debug.Log(profile.Name+ " " + profile.Height); // bbb,eee,ccc ³ª¿È
        
    }

 
}
