<Query Kind="Program" />

void Main()
{
	
	BinaryTreeNode root = new BinaryTreeNode(1);
	root.Left = new BinaryTreeNode(2);
	root.Right = new BinaryTreeNode(3);
	root.Left.Left = new BinaryTreeNode(4);
	root.Left.Right = new BinaryTreeNode(5);
	root.Right.Right = new BinaryTreeNode(6);
	
	//Problem 1
	//root.PrintAllPathsToLeaf(root, new List<int>());
	
	//problem 2: Find least common ancestor
	//	var result = BinaryTreeNode.LCA(root, root.Left, root.Left.Left);
	//	if(result.Item2 == true)
	//		Console.Write(result.Item1.Data);
	//	else
	//		Console.Write("Not exist");
		
	//problem 3 Construct tree from given preorder/inorder
	var preOrder = BinaryTreeNode.PreOrder(root, new List<int>());
	var inOrder = BinaryTreeNode.InOrder(root, new List<int>());
	var newTree = BinaryTreeNode.BuildTreeFromPreAndIn(preOrder, inOrder, 0, 0, inOrder.Count - 1);
	BinaryTreeNode.PreOrder(newTree, new List<int>()).Dump();
	
}

// Define other methods and classes here
public class BinaryTreeNode
{
	public int Data;
	public BinaryTreeNode Left;
	public BinaryTreeNode Right;
	
	public BinaryTreeNode(int data)
	{
		this.Data =data;
	}
	
	public void PrintAllPathsToLeaf(BinaryTreeNode root, List<int> Path)
	{
		if(root == null)
		{
			return;
		}
		
		Path.Add(root.Data);
		PrintAllPathsToLeaf(root.Left, Path);
		PrintAllPathsToLeaf(root.Right, Path);
		if(root.Left == null && root.Right == null)
		{
			Path.Dump();
		}
		
		if(Path.Any())
		{
			Path.RemoveAt(Path.Count - 1);
		}
	}
	
	public static BinaryTreeNode BuildTreeFromPreAndIn(List<int> Pre, List<int> In, int pIndex, int inStart, int inEnd)
	{
		if(pIndex >= Pre.Count || inStart > inEnd)
		{
			return null;
		}
			
		int i = pIndex;
		int j = inStart;
		BinaryTreeNode root = null;
		for(;i<Pre.Count;i++)
		{
			j = inStart;
			for(; j<= inEnd;j++)
			{
				if(Pre[i] == In[j])
				{
					root = new BinaryTreeNode(Pre[i]);
					root.Left = BuildTreeFromPreAndIn(Pre,In,i+1,inStart, j-1);
					root.Right = BuildTreeFromPreAndIn(Pre,In,i+1,j+1, inEnd);
					return root;
				}
			}
		}

		return root;
	}
	
	public static List<int> PreOrder(BinaryTreeNode root, List<int> traversalList)
	{
		if(root == null)
			return traversalList;
		traversalList.Add(root.Data);
		PreOrder(root.Left, traversalList);
		PreOrder(root.Right, traversalList);
		return traversalList;
	}
	
	public static List<int> InOrder(BinaryTreeNode root, List<int> traversalList)
	{
		if(root == null)
			return traversalList;
		InOrder(root.Left, traversalList);
		traversalList.Add(root.Data);
		InOrder(root.Right, traversalList);
		return traversalList;
	}
	
	public static Tuple<BinaryTreeNode,bool> LCA(BinaryTreeNode root, BinaryTreeNode A, BinaryTreeNode B)
	{
		if(root == null)
			return new Tuple<BinaryTreeNode,bool>(root,false);
		
		if(root.Data == A.Data)
			return new Tuple<BinaryTreeNode, bool>(root, FindNode(root, B));
		
		if(root.Data == B.Data)
			return new Tuple<BinaryTreeNode, bool>(root, FindNode(root, A));
			
		var leftResult = LCA(root.Left, A, B);
		if(leftResult.Item2 == true)
			return leftResult;
		
		var rightResult = LCA(root.Right, A, B);
		if(rightResult.Item2 == true)
			return rightResult;

		if(leftResult.Item1 != null && rightResult.Item1 != null)
			return new Tuple<BinaryTreeNode,bool>(root, true);
		if(leftResult.Item1 != null)
			return new Tuple<BinaryTreeNode,bool>(leftResult.Item1, false);
		else
			return new Tuple<BinaryTreeNode,bool>(rightResult.Item1, false);
	}
	
	public static bool FindNode(BinaryTreeNode root, BinaryTreeNode n)
	{
		if(root == null)
			return false;
			
		if(root.Data == n.Data)
			return true;
		
		return FindNode(root.Left, n) || FindNode(root.Right, n);
	}
}