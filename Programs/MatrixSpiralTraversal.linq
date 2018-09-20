<Query Kind="Program" />

//Print array in spiral
//1 2 3
//8 9 4
//7 6 5
//Output: 123456789
public enum Direction
{
	Right = 0,
	Down,
	Left,
	Up
}

void Main()
{
	int[,] input = new int[,]{	{1,2,3,4},
								{10,11,12,5},
								{9,8,7,6}};
	TraverseMatrix(input,0,2,0,3,0,0,Direction.Right);
	input.Dump();
}

// Define other methods and classes here
void TraverseMatrix(int[,] input, int startRow, int endRow, int startColumn, int endColumn, int currentRow, int currentColumn, Direction direction)
{
	if(startRow > endRow || startColumn > endColumn)
	{
		return;
	}

	switch(direction)
	{
		case Direction.Right:
		{
			for(int i = currentColumn; i <= endColumn; i++)
			{
				Console.WriteLine(input[currentRow,i]);
			}
			
			TraverseMatrix(input, startRow + 1, endRow, 
							startColumn, endColumn, 
							startRow + 1, endColumn, 
							Direction.Down);
			return;
		}
		case Direction.Left:
		{
			for(int i = currentColumn; i >= startColumn; i--)
			{
				Console.WriteLine(input[currentRow,i]);
			}
			
			TraverseMatrix(input, startRow, endRow - 1, 
				startColumn, endColumn, 
				endRow - 1, startColumn, 
				Direction.Up);
			return;
		}
		case Direction.Down:
		{
			for(int i = currentRow; i <= endRow; i++)
			{
				Console.WriteLine(input[i,currentColumn]);
			}
			
			TraverseMatrix(input, startRow, endRow, 
							startColumn, endColumn - 1, 
							endRow, endColumn - 1, 
							Direction.Left);
			return;
		}
		case Direction.Up:
		{
			for(int i = currentRow; i >= startRow; i--)
			{
				Console.WriteLine(input[i,currentColumn]);
			}
			
			TraverseMatrix(input, startRow, endRow, 
							startColumn + 1, endColumn, 
							startRow, startColumn + 1, 
							Direction.Right);
			return;
		}
	}
}