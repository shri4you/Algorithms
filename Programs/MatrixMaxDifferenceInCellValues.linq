<Query Kind="Program" />

//Given an n x n matrix A(i,j) of integers, find maximum value A(c,d) - A(a,b) over all choices of indexes such that both c > a and d > b.
//Required complexity: O(n^2)

void Main()
{
	int[,] input = new int[3,3]{{10,11,3},{2,5,11},{10,8,9}};
	input.Dump();
	
	int result = input[0,0];
	
	for(int i = 0; i < input.GetLength(0); i++)
	{
		for(int j=0; j < input.GetLength(1); j++)
		{
			if(i>0 && j>0)
			{
				result = Math.Max(result, input[i,j] - input[i-1,j-1]);
			}
			
			input[i,j] = GetMinValue(i,j,input);
		}
	}
	
	input.Dump();
	Console.WriteLine(result);
}

int GetMinValue(int i, int j, int[,] input)
{
	int min = input[i,j];
	if(i > 0)
	{
		min = Math.Min(min, input[i-1,j]);
	}
	
	if(j > 0)
	{
		min = Math.Min(min, input[i,j-1]);
	}
	
	if(i > 0 && j > 0)
	{
		min = Math.Min(min, input[i-1,j-1]);
	}
	
	return min;
}