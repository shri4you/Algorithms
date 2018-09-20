<Query Kind="Program" />

void Main()
{
	Console.WriteLine(AddWithoutArithmetic(7,-8));
}

static int AddWithoutArithmetic(int a, int b)
{
	if(b ==0) //Exit condition, carriage is 0
		return a;
		
	int sum = a ^ b; // Sum without considering carriage
	int c = (a & b)<<1; // Carry, but don't add.
	return AddWithoutArithmetic(sum,c);
}