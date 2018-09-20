<Query Kind="Program" />

void Main()
{
	/*
	Random set of WORD. 
	Criterion : Given a word find out if the word can be broken into smaller word, by removing one alphabet at a time.
	 a) all such word should be valid dictionary word.( Assume a function is there to test whether the word exist in dictionary)
	 b) Remove one alphabet at a time but the new word need to be in dictionary. 
	
	For eg : 
	restated -> restate -> estate -> state -> stat -> sat -> at -> a 
	fullfill the criterion. ( single alphabet assume belong to dict) 
	*/
	string r = "tale";
	Console.WriteLine(DoesMeetCriteria(0,r.Length-1,r));
}

// Define other methods and classes here
HashSet<string> dict = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"tale",
		"ale",
		"le",
	};
	
	bool DoesMeetCriteria(int startIndex, int endIndex, string input)
	{
		Console.WriteLine(input.Substring(startIndex,endIndex - startIndex + 1));
		if(startIndex == endIndex)
			return true;
		else if(startIndex > endIndex)
			return false;
		if(!dict.Contains(input.Substring(startIndex,endIndex - startIndex + 1)))
		{
			return false;
		}
		else
			return DoesMeetCriteria(startIndex + 1,endIndex,input) || DoesMeetCriteria(startIndex,endIndex - 1,input);
	}