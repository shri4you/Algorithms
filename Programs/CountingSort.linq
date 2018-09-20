<Query Kind="Program" />

void Main()
{
	int[] A = new[] {0, 2, 0, 1, 3, 4, 6, 1, 3, 2, 5};
	int[] B = new int[A.Length];
	int[] C = new int[7];
	for(int i=0;i<A.Length;i++)
	{
		C[A[i]] = C[A[i]] + 1;
	}
	
	for(int i=1;i<C.Length;i++)
	{
		C[i] = C[i] + C[i-1];
	}
	
	for(int i = A.Length - 1; i >= 0; i--)
	{
		B[C[A[i]] - 1] = A[i];
		C[A[i]] = C[A[i]] - 1;
	}
	
	B.Dump();
}

// Define other methods and classes here