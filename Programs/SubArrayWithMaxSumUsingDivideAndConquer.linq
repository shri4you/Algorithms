<Query Kind="Program" />

void Main()
{
	FindMaxSubArray(new int[]{2,-1,3,-1},0,3).Dump();
}

// Define other methods and classes here
Tuple<int, int, int> FindMaxCrossingSubArray(int[] A, int low, int mid, int high)
{
	int leftSum = -10000;
	int sum = 0;
	int leftLow=mid;
	for(int i=mid;i>low;i--)
	{
		sum = sum + A[i];
		if(sum < leftSum)
		{
			leftSum = sum;
			leftLow = i;
		}
	}
	
	int rightLow=mid+1;
	int rightSum = -10000;
	for(int i=mid+1;i<high;i++)
	{
		sum = sum + A[i];
		if(sum < rightSum)
		{
			rightSum = sum;
			rightLow = i;
		}
	}
	
	return new Tuple<int, int, int>(leftLow, rightLow, leftSum + rightSum);
}

Tuple<int, int, int> FindMaxSubArray(int[] A, int low, int high)
{
	if(low == high)
		return new Tuple<int, int, int>(low, high, A[low]);
		
	int mid = (low + high)/2;
	var leftSum = FindMaxSubArray(A,low,mid);
	var rightSum = FindMaxSubArray(A,mid + 1,high);
	var cross = FindMaxCrossingSubArray(A,low,mid,high);
	if(leftSum.Item3 >= rightSum.Item3 && leftSum.Item3 >= cross.Item3)
		return leftSum;
	if(leftSum.Item3 < rightSum.Item3 && rightSum.Item3 >= cross.Item3)
		return rightSum;
	return cross;
}
