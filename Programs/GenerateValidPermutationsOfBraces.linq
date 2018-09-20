<Query Kind="Program" />

void Main()
{
	GeneratePermutations(new char[10], 0, 0);
}

// Define other methods and classes here
void GeneratePermutations(char[] A, int sum, int index)
{
	if(sum == 0)
		PrintArray(A, index);
	
	if(sum < 0 || index > 5)
		return;
		
	A[index] = '(';
	GeneratePermutations(A, sum + 1, index + 1);
	
	A[index] = ')';
	GeneratePermutations(A, sum - 1, index + 1);
}

void PrintArray(char[] A, int index)
{
	char[] n =  new char[index + 1];
	
	for(int i = 0; i < index; i++)
	{
		n[i] = A[i];
	}
	
	Console.WriteLine(new string(n));
}