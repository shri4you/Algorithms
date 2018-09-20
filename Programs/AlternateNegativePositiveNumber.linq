<Query Kind="Program" />

// Given an array consisting of both positive and negative numbers, 0 is considered as positive, 
// rearrange the elements such that positive and negative numbers are placed alternatively, 
// constraints are that it should be in-place and order of elements should not change.
void Main()
{
	int[] input = {11,1,-1};//, 0,1,-12,100,29,-1,-2,-3, -4, -5};
	
	int storeInput = 0;
	bool storePositive = input[0] >= 0;
	bool found = true;
	Func<int,bool,bool> check = (v,sp) => {return (sp && v >= 0) || (!sp && v < 0);};
	while(found && storeInput < input.Length)
	{
		if(check(input[storeInput],storePositive))
		{
			storeInput = storeInput + 1;
			storePositive = !storePositive;
		}
		else
		{
			var r = GetNextIndexAndShift(storeInput,input,storePositive,check);
			if(r.Item2)
			{
				input[storeInput] = r.Item1;
				storeInput = storeInput + 1;
				storePositive = !storePositive;
			}
			else
			{
				found = false;
			}
		}
	}
	
	for(int i=0;i<input.Length;i++)
		Console.WriteLine(input[i]);
}

Tuple<int,bool> GetNextIndexAndShift(int from, int[] input, bool sp,Func<int,bool,bool> check)
{
	bool found = false;
	int nextIndex = 0;
	int returnValue;
	for(int i=from;i<input.Length;i++)
	{
		if(check(input[i],sp))
		{
			nextIndex = i;
			found = true;
			break;
		}
	}
	
	if(found)
	{
		returnValue = input[nextIndex];
		for(int j = nextIndex;j>from;j--)
		{
			input[j] = input[j - 1];
		}
		
		return new Tuple<int,bool>(returnValue,true);
	}
	return new Tuple<int,bool>(0,false);
}

// Define other methods and classes here
