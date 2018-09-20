<Query Kind="Program" />

void Main()
{
	var h = new MaxHeap();
	h.HeapSort();
}

// Define other methods and classes here
public class MaxHeap
{
	public int[] A = new int[] { 12, 43, -1, 18, 99, 2, 8, 2213};
	public int Capacity{get; private set;}
	
	public MaxHeap()
	{
		Capacity = 7;
	}
	
	public int GetLeftIndex(int i)
	{
		return (i * 2) + 1;
	}
	
	public int GetRightIndex(int i)
	{
		return (i + 1) * 2;
	}
	
	public int GetParentIndex(int i)
	{
		return (i - 1)/2;
	}
	
	public void Insert(int data)
	{
		Capacity = Capacity + 1;
		A[Capacity] = -10000;
		IncreaseKey(Capacity, data);
	}
	
	public void HeapSort()
	{
		BuildHeap();
		while(Capacity >= 0)
		{
			Console.WriteLine(ExtractMax());
		}
	}
	
	public int ExtractMax()
	{
		int temp = A[0];
		A[0] = A[Capacity];
		Capacity = Capacity - 1;
		MaxHeapify(0);
		return temp;
	}
	
	public void BuildHeap()
	{
		for(int i = (Capacity - 1)/2; i >= 0; i--)
		{
			MaxHeapify(i);
		}
	}
	
	public void MaxHeapify(int i)
	{
		int left = GetLeftIndex(i);
		int right = GetRightIndex(i);
		if(left <= Capacity && right <= Capacity)
		{
			if(A[left] > A[right])
			{
				if(A[left] > A[i])
				{
					Swap(left, i);
					MaxHeapify(left);
				}
			}
			else if(A[right] > A[i])
			{
				{
					Swap(right, i);
					MaxHeapify(right);
				}
			}
		}
		else if(left <= Capacity && A[left] > A[i])
		{
			Swap(left, i);
			MaxHeapify(left);
		}
		else if(right <= Capacity && A[right] > A[i])
		{
			Swap(right, i);
			MaxHeapify(right);
		}
	}
	
	private void Swap(int i, int j)
	{
		int temp = A[i];
		A[i] = A[j];
		A[j] = temp;
	}
	
	public void IncreaseKey(int i, int data)
	{
		A[i] = data;
		if(i>0)
		{
			int parentIndex = GetParentIndex(i);
			if(A[i] > A[parentIndex])
			{
				A[i] = A[parentIndex];
				IncreaseKey(parentIndex, data);
			}
		}
	}
}