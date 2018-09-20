<Query Kind="Program" />

void Main()
{
	char[] input = new char[] {'a','b'};
	MakePermutation(input, new bool[input.Length], new char[input.Length], 0);
}

// Define other methods and classes here
void MakePermutation(char[] input, bool[] selected, char[] permutation , int index)
{
	if(index >= input.Length)
	{
		(new string(permutation)).Dump();
		return;
	}
	
	for(int i = 0; i < input.Length; i++)
	{
		if(selected[i] == false)
		{
			selected[i] = true;
			permutation[index] = input[i];
			MakePermutation(input, selected, permutation, index + 1);
			selected[i] = false;
		}
	}
}