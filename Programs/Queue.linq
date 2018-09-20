<Query Kind="Program" />

// used to store n-1 elements

class Queue
{
	int[] dataStore = new int[10];
	int head = 0;
	int tail = 0;
	
	public bool IsQueueEmpty()
	{
		return head == tail;
	}
	
	public void Enqueue(int item)
	{
		if(this.head == (this.tail + 1) % this.dataStore.Length)
		{
			throw new Exception("full");
		}
		
		dataStore[this.tail] = item;
		this.tail = (this.tail + 1) % dataStore.Length;
	}
	
	public int Dequeue()
	{
		if(IsQueueEmpty())
		{
			throw new Exception("Queue is empty");
		}
		
		int item = this.dataStore[head];
		this.head = (this.head + 1) % dataStore.Length;
		return item;
	}
	
	public void Print()
	{
		this.dataStore.Dump();
	}
}

void Main()
{
	Queue q = new Queue();
	for(int i=0;i<9;i++)
	{
		q.Enqueue(i);
	}
	
	q.Dequeue();
	q.Dequeue();
	q.Dequeue();
	q.Enqueue(10);
	q.Enqueue(11);
	q.Dequeue();
	q.Enqueue(12);
	q.Enqueue(13);
	
	while(!q.IsQueueEmpty())
	{
		Console.WriteLine(q.Dequeue());
	}
	
	Console.Write("complete dequeue");
	for(int i=0;i<9;i++)
	{
		q.Enqueue(i);
	}
	
	
	while(!q.IsQueueEmpty())
	{
		Console.WriteLine(q.Dequeue());
	}
}

// Define other methods and classes here