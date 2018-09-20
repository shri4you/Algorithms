<Query Kind="Statements" />

/*
//5.1 You are given two 32-bit numbers, N and M, and two bit positions, i and j. Write a method to set all bits between i and j in N equal to M (e.g., M becomes a substring of N located at i and starting at j).
//EXAMPLE:
//Input: N = 10000000000, M = 10101, i = 2, j = 6
//Output: N = 10001010100

BitArray N = new BitArray(new bool[]{true,false,false,false,false,false,false,false,false,false,false});
BitArray M = new BitArray(new bool[]{true,false,true,false,true});

Console.WriteLine(N);
int j=0;
for(int i=2;i<6;i++)
{
	N[i] = M[j];
	j++;
}

Console.WriteLine(N);
*/

//Given a (decimal - e.g. 3.72) number that is passed in as a string, print the binary representation. If the number can not be represented accurately in binary, print “ERROR”

decimal d = (decimal)3.72;
int intPart = (int)d;
BitArray a = new BitArray(10);
int i =0;
while(intPart>0)
{
a[i] = intPart % 2 == 0?false:true;
intPart = (int)(intPart/2);
i++;
}

Console.Write(a);