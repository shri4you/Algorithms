<Query Kind="Program" />

void Main()
{
	int[] input = new[] {15,16,19,20,25,1,3,4,5,7,10,14};
	BinarySearch(input,0,input.Length - 1, 16);
}

// Define other methods and classes here
void BinarySearch(int[] input, int start, int end, int num)
{
	if(start > end)
		return;
		
	int mid = (start+end)/2;
	// Console.WriteLine("Start: {0}, mid: {1}, end:{2}", input[start], input[mid], input[end]);
	if(input[mid] == num)
		Console.WriteLine(mid);
		
	if(input[start] > input[end])
	{
		BinarySearch(input, start, mid - 1, num);
		BinarySearch(input, mid + 1, end, num);
	}
	else if(input[mid] < num)
	{
		BinarySearch(input, mid + 1, end,num);
	}
	else
	{
		BinarySearch(input, start, mid - 1,num);
	}
}