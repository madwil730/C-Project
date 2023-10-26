using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

class SlideTask
{
    int count;

    public SlideTask(int count)
    {
        this.count = count;
    }

    public void KeepAlive()
    {
        try
        {
            while(count > 0)
            {
                Debug.Log(count--);
                Thread.Sleep(10);
            }
        }
        catch(Exception e)
        {
            Thread.ResetAbort();

        }
        finally
        {
            Debug.Log("Clearing resource");

        }
    }
}
public class AbortingThread : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SlideTask task = new SlideTask(100);
        Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
        t1.IsBackground = false;

        t1.Start();
        Thread.Sleep(100);

        t1.Abort(); // 스레드 취소
        t1.Join();
    }

  
}
