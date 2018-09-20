<Query Kind="Program" />

//Question 1 / 3 (Odd even level difference) 
//You are given a function calcDifference which takes in the root pointer of a binary tree as it's input. 
//Complete the function to return the sum of values of nodes at odd height - sum of values of node at even height. Consider the root node is at height 1
// 
//Sample Input: 
//
//Sample Output 
//-74 
//
//Explanation: 
//[ (1 + 4 + 5 + 6 + 7 ) ? (2 + 3 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15) = -74 ]

void Main()
{

	TreeNode T = new TreeNode(10);
	T.Left = new TreeNode(5);
	T.Left.Left = new TreeNode(3);
	T.Right = new TreeNode(11);
	T.Right.Left = new TreeNode(10);
	T.Right.Right = new TreeNode(12);
	T.Right.Right.Right = new TreeNode(21);
	
	Console.Write(PreOrder(T, 1));
	
}

// Define other methods and classes here
//int PreOrder(TreeNode T, int sum, int height)
//{
//	if(T== null)
//		return sum;
//	
//	if(height % 2 != 0)
//		sum = sum - T.value;
//	else
//		sum = sum + T.value;
//		
//	sum = PreOrder(T.Left,sum,height+1);
//	sum = PreOrder(T.Right,sum,height+1);
//	return sum;
//}

int PreOrder(TreeNode T, int height)
{
	if(T==null)
		return 0;
	
	int nodeValue = T.value;
	if(height % 2 != 0)
		nodeValue = -1 * nodeValue;
	
	return nodeValue + PreOrder(T.Left, height + 1) + PreOrder(T.Right, height + 1);
}