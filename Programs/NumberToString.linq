<Query Kind="Program" />

void Main()
{
	Console.WriteLine(GetWorded(1800));
}

// Define other methods and classes here
static Dictionary<int, string> data = new Dictionary<int,string>
	{
{0,"zero"},
{1,"one"},
{2,"two"},
{3,"three"},
{4,"four"},
{5,"five"},
{6,"six"},
{7,"seven"},
{8,"eight"},
{9,"nine"},
{10,"ten"},
{11,"eleven"},
{12,"twelve"},
{13,"thirteen"},
{14,"fourteen"},
{15,"fifteen"},
{16,"sixteen"},
{17,"seventeen"},
{18,"eighteen"},
{19,"ninteen"},
{20,"twenty"},
{30,"thirty"},
{40,"forty"},
{50,"fifty"},
{60,"sixty"},
{70,"seventy"},
{80,"eighty"},
{90,"ninty"}
	};
	
	
	static string GetWorded(int num)
	{
		StringBuilder sb = new StringBuilder();
		if(num > 999)
		{
			sb.Append(GetWorded((int)num/1000));
			sb.Append(" thousand ");
			sb.Append(GetWorded(num % 1000));
			return sb.ToString();
		}	
		else if(num > 100)
		{
			sb.Append(GetWorded((int)num/100));
			sb.Append(" hundred ");
			sb.Append(GetWorded(num % 100));
			return sb.ToString();
		}
		else if(data.ContainsKey(num))
		{
			sb.Append(data[num]);
			return sb.ToString();
		}
		else
		{
			int val = num % 10;
			int temp = num - val;
			sb.Append(GetWorded(temp) + " ");
			return sb.ToString();
		}
	}