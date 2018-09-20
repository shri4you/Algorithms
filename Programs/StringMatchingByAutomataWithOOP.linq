<Query Kind="Program" />

public class FiniteAutomaton
{
	private string Pattern{get;set;}
	private int[,] TransistionMatching {get;set;}
	private char[] AlphabetSet{get;set;}
	private Dictionary<char,int> CharacterToIndexMapping{get; set;}
	public FiniteAutomaton(string pattern, char[] alphabetSet)
	{
		this.Pattern = pattern;
		this.AlphabetSet = alphabetSet;
		this.CharacterToIndexMapping = new Dictionary<char,int>();
		
		for(int i=0; i<alphabetSet.Length;i++)
		{
			this.CharacterToIndexMapping.Add(alphabetSet[i], i);
		}
	}
	
	public void InitializeAutomaton()
	{
		this.TransistionMatching = new int[this.Pattern.Length + 1, this.AlphabetSet.Length];
		int m = Pattern.Length;
		for(int q = 0; q <= m; q++)
		{
			string automataPattern = Pattern.Substring(0, q);
			for(int i = 0; i < this.AlphabetSet.Length; i++)
			{
				char a = this.AlphabetSet[i];
				string au = automataPattern + a;
				if(au.Length > m)
				{
					au = au.Substring(au.Length - m);
				}
				
				while(!IsPrefix(this.Pattern, au))
				{
					au = au.Remove(0,1);
				}
				
				this.TransistionMatching[q, i] = au.Length;
			}
		}
		
		this.TransistionMatching.Dump();
	}
	
	bool IsPrefix(string P, string automataPattern)
	{
		if(automataPattern.Length == 0)
			return true;
			
		for(int i=0; i < automataPattern.Length; i++)
		{
			if(automataPattern[i] != P[i])
			{
				return false;
			}
		}
		
		return true;
	}
	
	public void Match(string input)
	{
		int n = input.Length;
		int q = 0;
		for(int i = 0; i < n; i++)
		{
			q = this.TransistionMatching[q,this.CharacterToIndexMapping[input[i]]];
			if(q == this.Pattern.Length)
			{
				Console.WriteLine("Valid shift:" + (i+1 - q).ToString());
			}
		}
	}
}

void Main()
{
	string P = "ababaca";
	char[] Sigma = new[]{'a','b','c'};
	var F = new FiniteAutomaton(P,Sigma);
	F.InitializeAutomaton();
	F.Match("bababacaababbacaababaca");
}