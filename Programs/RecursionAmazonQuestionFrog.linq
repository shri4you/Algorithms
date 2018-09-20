<Query Kind="Program" />

void Main()
{
	//given an input array of integers where each integer represent the maximum amount of jump a frog can take.
	//Frog has to reach the end of the array in minimum number of jumps.
	//Example:[1 5 4 6 9 3 0 0 1 3] answer is 3 for this. 
	//[2 8 3 6 9 3 0 0 1 3] answer is 2 for this
	int[] input = new []{2, -1, 3, 6, 9, 3, 0, 0, 1, 3};
	Console.WriteLine(FindMinimumJumps(input,0,0));
}

// Define other methods and classes here
int MinimumFrogJumps(int[] input, int position)
{
	if(position == input.Length - 1)
	{
		return 0;
	}
	else if(position >= input.Length || input[position] <= 0)
	{
		return 1000;
	}
	
	int minJumps = 1000;
	for(int i = 1; i <= input[position]; i++)
	{
		minJumps = Math.Min(minJumps, MinimumFrogJumps(input, position + i));
	}

	return 1 + minJumps;
}