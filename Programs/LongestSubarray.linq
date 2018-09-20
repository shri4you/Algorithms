<Query Kind="Program" />

//Input: arr[] = {1, 0, 1, 1, 1, 0, 0}
//Output: 1 to 6 (Starting and Ending indexes of output subarray)

//Input: arr[] = {1, 1, 1, 1}
//Output: No such subarray

//Input: arr[] = {0, 0, 1, 1, 0}
//Output: 0 to 3 Or 1 to 4

void Main()
{
	var result = FindSubArray(0,input);
	Console.WriteLine("start {0}, end {1}",result.Item1, result.Item2);
}

static int[] input = {1, 1, 1, 1, 1, 0, 0};

// Define other methods and classes here
static Tuple<int,int> FindSubArray(int startIndex, int[] input)
{
	int endIndex = startIndex;
	int oneCount = 0, zeroCount = 0;
	for(int i = startIndex;i<input.Length;i++)
	{
		if(input[i] == 1)
		{
			oneCount = oneCount + 1;
		}
		else
		{
			zeroCount = zeroCount + 1;
		}
		
		if(oneCount == zeroCount)
		{
			endIndex = i;
		}
	}
	
	Tuple<int,int> subProblemSolution;
	if(startIndex < input.Length - 1)
	{
		subProblemSolution = FindSubArray(startIndex +1,input);
		if((subProblemSolution.Item2 - subProblemSolution.Item1) > (endIndex - startIndex))
		{
			return subProblemSolution;
		}
	}
	
	return new Tuple<int,int>(startIndex, endIndex);
}