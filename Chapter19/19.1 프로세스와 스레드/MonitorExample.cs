using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

class Counter
{
	const int LOOP_COUNT = 100;

	readonly object thisLock;
	bool lockedCount = false;
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
		while (loopCount-- > 0)
		{
			lock (thisLock) // 农府萍拿 冀记 积己
			{
				while(count >0 || lockedCount == true)
					Monitor.Wait(thisLock);

				lockedCount = true;
				count++;
				lockedCount = false;
				Monitor.Pulse(thisLock);	
			}
		}
	}

	public void Decrease()
	{
		int loopCount = LOOP_COUNT;
		while (loopCount-- > 0)
		{
			lock (thisLock) // 农府萍拿 冀记 积己
			{
				while (count < 0 || lockedCount == true)
					Monitor.Wait(thisLock);

				lockedCount = true;
				count--;
				lockedCount = false;
				Monitor.Pulse(thisLock);
			}
		}
	}
}

public class MonitorExample : MonoBehaviour
{
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
