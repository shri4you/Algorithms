<Query Kind="Program" />

void Main()
{
	mappings[1] = new char[]{'1'};
	mappings[2] = new char[]{'A','B','C'};
	mappings[4] = new char[]{'G','H','I'};
	mappings[5] = new char[]{'J','K','L'};
	mappings[6] = new char[]{'M','N','O'};
	mappings[8] = new char[]{'T','U','V'};
	mappings[9] = new char[]{'W','X','Y','Z'};
	GeneratePerm(new int[]{6,1,4,8,1,5,4},0,string.Empty);
}

char[][] mappings = new char[10][];

// Define other methods and classes here
void GeneratePerm(int[] input, int numIndex, string solution)
{
	if(numIndex > input.Length - 1)
	{
		Console.WriteLine(solution);
		return;
	}
	
	int digit = input[numIndex];
	for(int i=0;i<mappings[digit].Length;i++)
	{
		GeneratePerm(input, numIndex + 1, solution + mappings[digit][i]);
	}
}