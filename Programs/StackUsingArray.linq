<Query Kind="Program" />

class Stack 
{
	int[] dataStore = new int[3];
	int top = -1;
	public int Pop()
	{
		if(this.StackEmpty())
		{
			throw new Exception("stack is empty");
		}
		
		int item = dataStore[this.top];
		this.top = this.top -1;
		return item;
	}
	
	public void Push(int item)
	{
		if(this.top + 1 >= dataStore.Length)
		{
			throw new Exception("Overflow");
		}
		
		this.top = this.top + 1;
		this.dataStore[this.top] = item;
	}
	
	public bool StackEmpty()
	{
		return this.top == -1;
	}
}

void Main()
{
	Stack s = new Stack();
	for(int i=0;i<3;i++)
	{
		s.Push(i);
	}
	
	while(!s.StackEmpty())
	{
		Console.WriteLine(s.Pop());
	}
}
