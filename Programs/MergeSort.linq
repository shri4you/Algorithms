<Query Kind="Program" />

void Main()
{
	int[] input = {6,3,-1,10,7,8,-2};
	divide(input,0,input.Length - 1);
	input.Dump();
}

// Define other methods and classes here
void divide(int[] input, int i, int j)
{
	if(i>=j)
	{
		return;
	}
	
	int mid = (i + j)/2;
	divide(input, i,mid);
	divide(input, mid + 1, j);
	Merge(input,i,mid,j);
}

void Merge(int[] input, int start, int mid, int end)
{
	int i = start, j=mid + 1;
	int bi = 0;
	int[] buffer = new int[end - start + 1];
	while(i <= mid || j <= end)
	{
		if( i <= mid && j <= end)
		{
			if(input[i] < input[j])
			{
				buffer[bi] = input[i];
				i++;
			}
			else
			{
				buffer[bi] = input[j];
				j++;
			}
		}
		else if(i <= mid)
		{
			buffer[bi] = input[i];
			i++;
		}
		else
		{
			buffer[bi] = input[j];
			j++;
		}
		
		bi++;
	}
	
	for(bi=0;bi<buffer.Length;bi++)
	{
		input[start] = buffer[bi];
		start++;
	}
}


