<Query Kind="Program" />

void Main()
{
	double d = 8.123;
	
	int i = (int)d;
	double f = d - i;
	
	Console.WriteLine(i);
	Console.WriteLine(f);
	
	Console.WriteLine(GetIntPart(i) + "." + GetDouble(f));
}

// Define other methods and classes here
string GetIntPart(int i)
{
	string s = string.Empty;
	while(i > 0)
	{
		s = (i % 2).ToString() + s;
		i = i/2;
	}
	
	return s;
}

string GetDouble(double d)
{
	string s = string.Empty;
	int c = 0;
	while(c < 5 && d > 0)
	{
	
		d=d*2;
		Console.WriteLine(d);
		if(d>1)
		{
			s = s + "1";
			d = d - 1;
		}
		else
		{
			s = s + "0";
		}
		
		c = c + 1;
	}
	
	return s;
}