<Query Kind="Program" />

void Main()
{
//	Given 2 binary arrays A and B i.e. containing only 0s and 1s each of size N. 
//	Find indices i,j such that Sum of elements from i to j in both arrays is equal and j-i (i.e. the length of the set i,j) is the maximum possible value.
	Tuple<int,int> result = FindMaxSubArray(0, 0);
	Console.WriteLine("start index " + result.Item1.ToString() + "end index" + result.Item2.ToString());
}

// Define other methods and classes here
BitArray A = new BitArray(new bool[]{false,true,false,false,true,true,false,false,false,true});
BitArray B = new BitArray(new bool[]{true,true,false,true,true,true,false,false,false,false});
Tuple<int,int> FindMaxSubArray(int startIndex, int currentMaxArrayLength)
{
	int endIndex = 0;
	int additionOfA = 0, additionOfB = 0;
	if(startIndex >= A.Length - 1)
	{
		return new Tuple<int,int>(startIndex, -1000);
	}
	
	bool executed = false;
	for(int i=startIndex; i < A.Length - currentMaxArrayLength; i++)
	{
		executed = true;
		additionOfA = additionOfA + Convert.ToInt32(A[i]);
		additionOfB = additionOfB + Convert.ToInt32(B[i]);
		if(additionOfA == additionOfB)
		{
			endIndex = i;
		}
	}
	
	Console.WriteLine(executed);
	int currentLength = endIndex - startIndex;
	currentLength = Math.Max(currentLength,currentMaxArrayLength);
	Tuple<int,int> subProblemSolution = FindMaxSubArray(startIndex + 1, currentLength);
	int subProblemLength = subProblemSolution.Item2 - subProblemSolution.Item1;
	if((subProblemLength) > (endIndex - startIndex))
	{
		return subProblemSolution;
	}
	else
	{
		return new Tuple<int,int>(startIndex,endIndex);
	}
}