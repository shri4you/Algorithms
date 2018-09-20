<Query Kind="Program" />

// tick tac toe
void Main()
{
}

public class TicTacToe
{
	private int[,] board = new int[3,3];
	Player[] players = new[]{new Player(1), new Player(2)};
	
	public void Play()
	{
		int numberOfInputs = board.GetLength(0) * board.GetLength(1);
		while(numberOfInputs > 0)
		{
			
		}
	}
	
	
}

public class Player
{
	public int PlayerId {get; private set;}
	public Player(int playerId)
	{
		this.PlayerId = playerId;
	}
	
	
}

public struct Coordinate
{
	public int Row {get; private set;}
	public int Column {get; private set;}
	
	public Coordinate(int row, int column)
	{
		this.Row = row;
		this.Column = column;
	}
}

// Define other methods and classes here
