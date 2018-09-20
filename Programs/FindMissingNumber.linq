<Query Kind="Program" />

// Find the missing number from array of 1 to n numbers
// i.e. 1,2,3,5,6 here 4 is missing

void Main()
{

	// Property used is: A ^ A = 0

	int[] input = new int[] {1,5,6,2,3};
	
	// do XOR of 1 to n
	int xorOf1toN = 0;
	for(int i = 1; i<=6;i++)
	{
		xorOf1toN = xorOf1toN ^ i;
	}
	
	int xorOfArray = 0;
	for( int i = 0; i <input.Length;i++)
	{
		xorOfArray = xorOfArray ^ input[i];
	}
	
	Console.WriteLine("Missing number {0}", xorOf1toN ^ xorOfArray);
}

// Define other methods and classes here
