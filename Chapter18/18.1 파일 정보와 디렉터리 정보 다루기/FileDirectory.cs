using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FileDirectory : MonoBehaviour
{

    void Start()
    {
        string path = "C:\\Users\\user\\Desktop\\Test";

        var directories = (from dir in Directory.GetDirectories(path)
                           let info = new DirectoryInfo(dir)
                           select new
                           {
                               Name = info.Name,
                               Attribute = info.Attributes  
                           }).ToList(); 

        foreach (var d in directories)  
            Debug.Log(d.Attribute);

        var files = (from file in  Directory.GetFiles(path)
					 let info = new FileInfo(file)
					 select new
					 {
						 Name = info.Name,
						 FileSize = info.Length,
                         Attribute = info.Attributes    
					 }).ToList();

		foreach (var f in files)
			Debug.Log(f.Name + " " + f.FileSize + " " + f.Attribute);


	}

  
}
