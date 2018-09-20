<Query Kind="Program" />

void Main()
{
	var kmpMatcher = new KMPMatcher("ababaca");
	kmpMatcher.ComputePrefixFunction();
	kmpMatcher.Match("1ababaca ababaca");
}

// Define other methods and classes here
public class KMPMatcher
{
	private string Pattern{get;set;}
	private int[] PrefixFunction {get;set;}
	public KMPMatcher(string pattern)
	{
		this.Pattern = pattern;
		
	}
	
	public void ComputePrefixFunction()
	{
		int m = Pattern.Length;
		this.PrefixFunction = new int[m];
		this.PrefixFunction[0] = -1;
		int k=-1;
		for(int q = 1; q < m; q++)
		{
			while(k > -1 && this.Pattern[k+1] != this.Pattern[q])
			{
				k = this.PrefixFunction[k];
			}

			if(this.Pattern[k+1] == this.Pattern[q])
				k = k + 1;
			this.PrefixFunction[q] = k;
		}
		
		this.PrefixFunction.Dump();
	}
	
	public void Match(string input)
	{
		int q = -1; // numbers of characters matched
		for(int i = 0; i < input.Length; i++)
		{
			while(q > -1 && this.Pattern[q+1] != input[i])
			{
				q = this.PrefixFunction[q];
			}
			
			if(this.Pattern[q+1] == input[i])
			{
				q = q + 1;
			}
			
			if(q == this.PrefixFunction.Length -1)
			{
				Console.WriteLine("patter occurs with shift {0}",i - this.Pattern.Length);
				q = this.PrefixFunction[q];
			}
		}
	}
}