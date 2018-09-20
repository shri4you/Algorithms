<Query Kind="Program" />

void Main()
{
	Console.WriteLine(AddWithoutArithmetic(3,3));
	Console.WriteLine(Mul(4,4));
	//new BitArray(new int[]{-7}).Dump();
}

static int AddWithoutArithmetic(int a, int b)
{
	if(b ==0) //Exit condition, carriage is 0
		return a;
		
	int sum = a ^ b; // Sum without considering carriage
	int c = (a & b)<<1; // Carry, but don't add.
	return AddWithoutArithmetic(sum,c);
}

static int SubtractWithoutArithmetic(int a, int b)
{
	return AddWithoutArithmetic(a,AddWithoutArithmetic(~b,1));
}

 public static int Mul(int a, int b)
    {
        int r = 0;
        while (b != 0)
        {
            var temp = b & 1;

            if (temp!= 0)
            {
                r = r + a;
            }
            a= a << 1;
            b= b >> 1;
           
        }

        return r;
    }