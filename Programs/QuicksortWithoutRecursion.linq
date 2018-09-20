<Query Kind="Program" />

// Quicksort without recursion

void Main()
{
	QuickSort(0, input.Length -1);
	
	for(int i=0;i<input.Length;i++)
	{
		Console.WriteLine(input[i]);
	}
}

// Define other methods and classes here
static int[] input = {11,2,1,0,6,5,3,4,170};
static void QuickSort(int start, int end)
{
	Stack<Tuple<int,int>> stack = new Stack<Tuple<int,int>>();
	int pivot;
	while(true)
	{
		if(start < end)
		{
			pivot = partition(start,end);
			stack.Push(new Tuple<int,int>(pivot+1,end));
			end = pivot - 1;
			continue;
		}
		
		if(stack.Any())
		{
			var newPair = stack.Pop();
			start = newPair.Item1;
			end = newPair.Item2;
			continue;
		}
		
		break;
	}
}

static int partition(int start, int end)
{
	int pivotIndex = (start + end)/2;
	int pivotValue = input[pivotIndex];
	input[pivotIndex] = input[end];
	input[end] = pivotValue;
	int temp;
	int storeIndex = start;
	for(int i = start;i<end;i++)
	{
		if(input[i] < pivotValue)
		{
			temp = input[storeIndex];
			input[storeIndex] = input[i];
			input[i] = temp;
			storeIndex++;
		}
	}
	
	input[end] = input[storeIndex];
	input[storeIndex] = pivotValue;
	return storeIndex;
}