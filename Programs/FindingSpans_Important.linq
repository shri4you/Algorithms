<Query Kind="Program" />

void Main()
{
	// Water in the buildings
	// Refer. Karumanchi Stacks chapter problem 23
	int[] input = new int[] {103,104,102,2,3,9,100};
	FindSpan(input);
}

// Define other methods and classes here

void FindSpan(int[] input)
{
	int[] S = new int[input.Length];
	Stack<int> stack = new Stack<int>(input.Length);
	for(int i=0;i<S.Length;i++)
	{
		while(stack.Any() && input[i] > input[stack.Peek()])
		{
			stack.Pop();
		}
		
		if(!stack.Any())
		{
			S[i] = i + 1;
		}
		else
		{
			S[i] = i - stack.Peek();
		}
		
		stack.Push(i);
	}
	
	S.Dump();
}