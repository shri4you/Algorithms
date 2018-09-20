<Query Kind="Program" />

void Main()
{
	List<List<string>> input = new List<List<string>>();
	
	input.Add(new List<string>{"a","b"});
	input.Add(new List<string>{"d","e","f","g"});
	input.Add(new List<string>{"h","i"});
	var e = new Enumerator(input);
	while(e.HasNext())
		Console.WriteLine(e.GetNext());
}

// Define other methods and classes here
public class Enumerator
{
	private List<List<string>> input;
	private int mIndex = -1;
	private int sIndex = -1;
	private int maxSIndex;
	public Enumerator(List<List<string>> input)
	{
		this.input = input;
		this.maxSIndex = input.Max(a=>a.Count);
	}
	
	public bool HasNext()
	{
		int m, s;
		return TryGetNext(out m, out s);
	}
	
	private bool TryGetNext(out int m, out int s)
	{
		m = this.mIndex;
		s = this.sIndex;
		while(s < this.maxSIndex)
		{
			m = (m+1)%input.Count;
			if(m == 0)
				s=s+1;
			
			if(input[m].Count > s)
				return true;
		}
		
		return false;
	}
	
	public string GetNext()
	{
		int m,s;
		if(this.TryGetNext(out m,out s))
		{
			this.mIndex = m;
			this.sIndex = s;
			return input[m][s];
		}
		
		return string.Empty;
	}
}