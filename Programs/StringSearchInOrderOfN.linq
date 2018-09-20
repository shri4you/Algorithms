<Query Kind="Program" />

/*Find the word in the given sentence.
i)Check whether it exists
ii)If exist means return count and index.
Ex:
string="CSK lost to RR"
substr="CSK"
CSK exist in above string.The substr CSK is presented at the index of 0-2 in string.
The count is 1.
*/

/* O(n) but can be used only when the search string doesn't have repetition */

void Main()
{

int i=0,j,tempI,count=0,n;
string A= "CSK lost CSKS to RR";
string B = "CSK";
n = A.Length;
while(i < n - B.Length)
{
	tempI = i;
	for(j=0;j<B.Length;j++)
	{
		if(A[tempI] != B[j])
		{
			tempI++;
			break;
		}
		else
		{
			tempI++;
		}
	}
	
	if(j == B.Length)
	{
		Console.WriteLine("start:{0},end:{1}",i,tempI - 1);
		count = count + 1;
	}
	
	i = tempI;
}

Console.WriteLine(count);
	
}

// Define other methods and classes here
