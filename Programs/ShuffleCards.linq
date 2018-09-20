<Query Kind="Program" />

void Main()
{
int[] cards = new Int32[52];
	for(int i=0;i<52;i++)
	{
		cards[i] = i + 1;
	}
	
	shuffleArray(cards);
	
	for(int i=0;i<52;i++)
	{
	Console.Write(" " + cards[i].ToString() + " ");
	}
}

// Define other methods and classes here
public static void shuffleArray(int[] cards) {
Random r = new Random();
int temp, index;
 for (int i = 0; i < cards.Length; i++){
 index = (int) (r.Next() % (cards.Length - i)) + i;
 temp = cards[i];
 cards[i] = cards[index];
 cards[index] = temp;
 }
 }