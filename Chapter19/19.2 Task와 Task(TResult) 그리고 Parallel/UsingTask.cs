using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class UsingTask : MonoBehaviour
{
    void Start()
    {
        string srcFile = "";

        Action<object> FileCopyAction = (object state) =>
        {
            string[] paths = (string[])state;
            File.Copy(paths[0], paths[1]);

            Debug.Log(Task.CurrentId);
            Debug.Log(Thread.CurrentThread.ManagedThreadId);
            Debug.Log(paths[0]);
            Debug.Log(paths[1]);
        };

        Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" }); // 생성자에서 넘겨받은 무명함수를 비동기로 호출 

        Task t2 = Task.Run(() =>
        {
            FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
        });

        t1.Start();

        Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

        t3.RunSynchronously();

        t1.Wait(); // t1 비동기 호출이 완료될 때가지 기다린다
        t2.Wait();
        t3.Wait();

	}

    
}
