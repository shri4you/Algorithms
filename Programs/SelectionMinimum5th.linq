<Query Kind="Program" />

void Main()
{
	int[] input = new[] {5,4,3,-1, -1, -2,1,0};
	Select(input, 0, input.Length-1, 3);
	//input.Dump();
}

// Define other methods and classes here
void Select(int[] input, int startIndex, int endIndex, int selectionIndex)
{
	if(startIndex > endIndex)
		return;
	int newPivotIndex = Partition(input, startIndex, endIndex);
	//Console.WriteLine(newPivotIndex);
	if(newPivotIndex == selectionIndex)
	{
		Console.WriteLine(input[newPivotIndex]);
	}
	else if(newPivotIndex > selectionIndex)
	{
		Select(input, startIndex, newPivotIndex - 1, selectionIndex);
	}
	else
	{
		Select(input, newPivotIndex + 1, endIndex, selectionIndex);
	}
}

int Partition(int[] input, int startIndex, int endIndex)
{
	int pivot = (startIndex + endIndex)/2;
	int storeIndex = startIndex;
	int key = input[pivot];
	int temp;
	input[pivot] = input[endIndex];
	input[endIndex] = key;
	for(int i=startIndex;i<endIndex;i++)
	{
		if(input[i] < key)
		{
			temp = input[storeIndex];
			input[storeIndex] = input[i];
			input[i] = temp;
			storeIndex++;
		}
	}
	
	input[endIndex] = input[storeIndex];
	input[storeIndex] = key;
	return storeIndex;
}