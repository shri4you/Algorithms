<Query Kind="Program" />

void Main()
{
	var result = LongestArrayWithMaxSum();
	Console.WriteLine("start:{0},end:{1},max{2}",result.Item1,result.Item2,result.Item3);
}

public static int[] data = {-2, -8, -1, -2, -4, -10};
// Define other methods and classes here
static Tuple<int, int, int> LongestArrayWithMaxSum()
{
	int currentStart=0, currentEnd=0, currentMax =0;
	int start=0, end=0, max =0;
	
	for(int i=0;i<data.Length - 1;i++)
	{
		currentMax = currentMax + data[i];
		currentEnd = i;
		if(currentMax < 0)
		{
			currentStart = i+1;
			currentMax = 0;
		}
		else if(currentMax > max)
		{
			max = currentMax;
			start = currentStart;
			end = currentEnd;
		}
	}
	
	return new Tuple<int,int,int>(start,end,max);
}