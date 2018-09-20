<Query Kind="Program" />

void Main()
{
	// Given array A[] of ints, maximum j - i, where A[j] > A[i]
	int[] A = new[] {4, 3, 2, 1};
	Stack<int> s1 = new Stack<int>();
	Stack<int> s2 = new Stack<int>();
	int startIndex = 0;
	int maxDifference;
	maxDifference = 0;
	s1.Push(0);
	for(int i = 1; i < A.Length; i++)
	{
		if(A[i] < A[s1.Peek()])
		{
			s1.Push(i);
		}
		else
		{
			while(s1.Any() && A[s1.Peek()] < A[i])
			{
				s2.Push(s1.Pop());
			}
			
			if(s2.Any() && i - s2.Peek() > maxDifference)
			{
				maxDifference = i - s2.Peek();
				startIndex = s2.Peek();
			}
			
			while(s2.Any())
			{
				s1.Push(s2.Pop());
			}
		}
	}
	
	maxDifference.Dump();
	startIndex.Dump();
}

// Define other methods and classes here
