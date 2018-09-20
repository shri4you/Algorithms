<Query Kind="Program" />

// n*n array with rows and columns ascending order find an element.

// This works but think more in terms of duplicate values etc.

void Main()
{
	int[,] input = new int[4,5]{{10, 50, 60, 61, 200},
					{12, 90, 100, 160, 400},
					{50, 104, 170, 180, 599},
					{61, 120, 190, 200, 600}};
	FindNumber(input,0,input.GetUpperBound(1),10);
	FindNumber(input,0,input.GetUpperBound(1),200);
	FindNumber(input,0,input.GetUpperBound(1),104);
	FindNumber(input,0,input.GetUpperBound(1),600);
	FindNumber(input,0,input.GetUpperBound(1),600);
	input.GetUpperBound(1).Dump();
}

// Define other methods and classes here
void FindNumber(int[,] input, int columnStart, int columnEnd, int number)
{
	if(columnStart > columnEnd)
		return;
	
	int mid = (columnStart + columnEnd) / 2;
	if(input[0,mid] <= number && number <= input[input.GetUpperBound(0), mid])
	{
		FindNumberInColumn(input, 0, input.GetUpperBound(0), mid, number);
	}
	
	if(mid > 0 && number <= input[input.GetUpperBound(0), mid - 1])
	{
		FindNumber(input,columnStart,mid-1,number);
	}
	
	if(mid < input.GetUpperBound(1) && input[0,mid + 1] <= number)
	{
		FindNumber(input,mid+1, columnEnd,number);
	}
}

void FindNumberInColumn(int[,] input, int rowStart, int rowEnd, int column, int number)
{
	if(rowStart > rowEnd)
		return;
		
	int mid = (rowStart + rowEnd)/2;
	if(input[mid, column] == number)
	{
		Console.WriteLine("Number: {0}, Row: {1}, Column: {2}",number, mid,column);
		return;
	}
	
	if(input[mid, column] < number)
	{
		FindNumberInColumn(input, mid + 1, rowEnd, column, number);
	}
	else if(input[mid, column] > number)
	{
		FindNumberInColumn(input, rowStart, mid - 1, column, number);
	}
}