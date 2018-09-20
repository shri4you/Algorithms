<Query Kind="Program" />

//Given a array of characters of this replace the characters which occur continously with the character and no. of times it occured 
//e.g. AAAABCCDDD A4BC3D3 (count for characters that occurs once can be ignored). Do it Inplace.

void Main()
{
	char[] input = new char[] {'A','A','A','A','B','C','C','D','D','D','A','A','E'};
	char currentAlph = input[0];
	int currentCount = 1;
	int n = input.Length;
	int storeindex = 0;
	for(int i=1;i<n;i++)
	{
		if (input[i] == currentAlph)
			currentCount++;
		else if(input[i] != currentAlph)
		{
			input[storeindex] = currentAlph;
			storeindex= storeindex+1;
			input[storeindex] = currentCount.ToString().ToCharArray()[0];
			storeindex = storeindex + 1;
			currentAlph = input[i];
			currentCount = 1;
		}
		
		input[i] = '_';
	}
	
	input[storeindex] = currentAlph;
	storeindex = storeindex+1;
	input[storeindex] = currentCount.ToString().ToCharArray()[0];
	Console.WriteLine(input);
}

// Define other methods and classes here
