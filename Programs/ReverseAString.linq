<Query Kind="Program" />

//This is test

void Main()
{
	string s = "This is test";
	var array = s.ToCharArray();
	Reverse(array, 0, array.Length - 1);
	array.Dump();
	int start = 0;
	for(int i=0;i<array.Length;i++)
	{
		if(array[i] == ' ')
		{
			Reverse(array,start,i-1);
			start = i + 1;
		}
		else if(i == array.Length - 1)
		{
			Reverse(array,start,i);
		}
	}
	
	array.Dump();
	
}

void Reverse(char[] input, int start, int end)
{
	char c;
	// Better method would be incrementing from start and decrementing from end.
	
	for(int i = 0; i < end - start - i; i++)
	{
		c = input[i + start];
		input[i + start] = input[end - i];
		input[end - i] = c;
	}
}

// Define other methods and classes here
