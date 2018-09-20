<Query Kind="Program" />

void Main()
{
	Heap h = new Heap();
	h.HeapSort();
	h.input.Dump();
}

public class Heap
{
	public int[] input = new int[]{5,4,3,2,1,0,-1};
	public int HeapSize;
	public Heap()
	{
		this.HeapSize = input.Length;
	}
	
	public void MaxHepify(int[] input, int i)
	{
		int left = Left(i);
		int right = Right(i);
		int largest = i;
		if(left < this.HeapSize && input[i] < input[left])
		{
			largest = left;
		}
				
		if(right < this.HeapSize && input[largest] < input[right])
		{
			largest = right;
		}
		
		if(largest != i)
		{
			Swap(largest, i);
			MaxHepify(input, largest);
		}
	}
	
	void Swap(int i, int j)
	{
		int temp = input[i];
		input[i] = input[j];
		input[j] = temp;
	}
	
	int Left(int i)
	{
		return (2 * i) + 1;
	}
	
	int Right(int i)
	{
		return (2 * i) + 2;
	}
	
	public void BuildHeap()
	{
		int lastNodeWithHeight1 = (input.Length-1)/2;
		for(int i = lastNodeWithHeight1; i >= 0; i--)
		{
			MaxHepify(input, i);
		}
	}
	
	public void HeapSort()
	{
		BuildHeap();
		for(int i=input.Length -1 ;i>=0;i--)
		{
			Swap(i,0);
			this.HeapSize = i-1;
			MaxHepify(input, 0);
		}
	}

}