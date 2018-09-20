<Query Kind="Program" />

void Main()
{
	var c = new char[]{'a','b','c','d'};
	GenerateCombinations(c,0,new char[c.Length],0);
}

// Define other methods and classes here
void GenerateCombinations(char[] A, int index, char[] currentCombination, int cIndex)
{
	if(index >= A.Length)
	{
		PrintArray(currentCombination, cIndex);
		return;
	}
	
	GenerateCombinations(A, index+1, currentCombination, cIndex);
	currentCombination[cIndex] = A[index];
	GenerateCombinations(A, index+1, currentCombination, cIndex+1);
}

void PrintArray(char[] currentCombination, int index)
{
	string s = new string(currentCombination,0,index);
	Console.WriteLine(s.ToString());
}