using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


class Counter
{
    const int LOOP_COUNT = 100;

    readonly object thisLock;
    private int count;
    public int Count { get { return count; } }  

    public Counter()
    {
        thisLock = new object();
        count = 0;
    }

    public void Increase()
    {
        int loopCount = LOOP_COUNT;
        while(loopCount-- > 0)
        {
            lock(thisLock) // 农府萍拿 冀记 积己
            {
                count++;
            }

            Thread.Sleep(1);
        }

	}

	public void Decrease()
	{
		int loopCount = LOOP_COUNT;
		while (loopCount-- > 0)
		{
			lock (thisLock) // 农府萍拿 冀记 积己
			{
				count--;
			}

			Thread.Sleep(1);
		}

	}

}

public class Synchronize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Counter counter = new Counter();

        Thread incThread = new Thread(new ThreadStart(counter.Increase));
        Thread decThread = new Thread(new ThreadStart(counter.Decrease));

        incThread.Start();
        decThread.Start();

        incThread.Join();
        decThread.Join();

        Debug.Log(counter.Count); //0
        
    }

    
}
