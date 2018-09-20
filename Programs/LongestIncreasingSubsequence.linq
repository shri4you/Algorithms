<Query Kind="Program" />

// Longest increasing subsequence
void Main()
{
	int[] A = new int[] { 10, 1, 102, 9, 10, 11, 12, -1 };
	LSI(A);
}

// Define other methods and classes here
void LSI(int[] A)
{
	if(A.Length == 0)
	{
		return;
	}
	
	// This is using bottom up dynamic programming.
	// its complicated to use top down and MEMOIZATION
	int[] table = new int[A.Length];
	int[] solution = new int[A.Length];
	
	table[0] = 1;
	solution[0] = 0;
	int overAllMax = 0;
	
	for(int i=1; i<table.Length; i++)
	{
		int maxLIS = 0;
		solution[i] = i;
		for(int j=i-1; j>= 0; j--)
		{
			if(A[j] < A[i] && maxLIS < table[j])
			{
				maxLIS = table[j];
				solution[i] = j;
			}
		}
		
		table[i] = 1 + maxLIS;
		overAllMax = Math.Max(overAllMax, table[i]);
	}
	
	Console.WriteLine(overAllMax);
	table.Dump();
	solution.Dump();
	PrintSolution(A, solution, 6);
}

void PrintSolution(int[] A, int[] solution, int index)
{
	Console.Write("{0} ", A[index]);
	while(index != solution[index])
	{
		index = solution[index];
		Console.Write("{0} ", A[index]);
	}
}
