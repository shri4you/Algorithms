<Query Kind="Program" />

//Given a string, write a function to determine if the string is a palindrome ignoring spaces. Your code should run optimally in a memory-constrained environment.      
//     eg "ABBA" = true
//        " ABB A" = true
//        "ABXA" = false
//        " ABBXBAB" = false


void Main()
{

	string input = "A B ACB A";
	int j = input.Length - 1;
	int i = 0;
	
	while(i<j)
	{
		if(input[i] == ' ')
		{
			i++;
			continue;
		}
		
		if(input[j] == ' ')
		{
			j--;
			continue;
		}
		
		if(input[i] != input[j])
		{
			Console.WriteLine("False");
			return;
		}
		
		i++;
		j--;
	}
	
	Console.WriteLine("True");
}

// Define other methods and classes here
