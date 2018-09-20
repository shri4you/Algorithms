<Query Kind="Program" />

// Construct BST for a given inorder and preorder traversal using ITERATIVE METHOD ONLY
void Main()
{
	TreeNode root = TreeNode.GetSampleTree(9);
	List<int> serializedTree = new List<int>();
	List<int> preorderTraversal = new List<int>();
	List<int> inorderTraversal = new List<int>();
	PreOrder(root,preorderTraversal);
	InOrder(root,inorderTraversal);
	TreeNode reconstructedTree = ConstructBinaryTree(preorderTraversal, inorderTraversal, 0, 0, inorderTraversal.Count - 1);
	List<int> reconstructedPreorder = new List<int>();
	List<int> reconstructedInorder = new List<int>();
	PreOrder(reconstructedTree,reconstructedPreorder);
	InOrder(reconstructedTree,reconstructedInorder);
	preorderTraversal.Dump();
	reconstructedPreorder.Dump();
	inorderTraversal.Dump();
	reconstructedInorder.Dump();
}

void PreOrder(TreeNode root, List<int> traversal)
{
	if(root == null)
		return;
	
	traversal.Add(root.value);
	PreOrder(root.Left,traversal);
	PreOrder(root.Right,traversal);
}

void InOrder(TreeNode root, List<int> traversal)
{
	if(root == null)
		return;
	
	InOrder(root.Left,traversal);
	traversal.Add(root.value);
	InOrder(root.Right,traversal);
}

TreeNode ConstructBinaryTree(List<int> preorderTraversal, List<int> inorderTraversal, int pIndex, int iStart,int iEnd)
{
	if(pIndex >= preorderTraversal.Count)
	{
		return null;
	}
	
	int inOrderIndex = InOrderIndex(inorderTraversal, iStart, iEnd,preorderTraversal[pIndex]);
	if(inOrderIndex == -1)
	{
		return null;
	}
	
	TreeNode root = new TreeNode(preorderTraversal[pIndex]);
	int nextpIndex;
	pIndex++;
	nextpIndex = GetFirstItemIndexFromInorder(preorderTraversal,inorderTraversal,pIndex, iStart, inOrderIndex-1);
	if(nextpIndex > -1)
	{
		pIndex++;
		root.Left = ConstructBinaryTree(preorderTraversal,inorderTraversal,nextpIndex, iStart, inOrderIndex);
	}
	
	nextpIndex = GetFirstItemIndexFromInorder(preorderTraversal,inorderTraversal,pIndex, inOrderIndex+1, iEnd);
	if(nextpIndex > -1)
	{
		root.Right = ConstructBinaryTree(preorderTraversal,inorderTraversal,nextpIndex, inOrderIndex, iEnd);
	}
	
	return root;
}

int GetFirstItemIndexFromInorder(List<int> preorderTraversal, List<int> inorderTraversal, int pIndex, int iStart, int iEnd)
{
	int inorderIndex;
	for(int i = pIndex;i<preorderTraversal.Count;i++)
	{
		inorderIndex = InOrderIndex(inorderTraversal,iStart,iEnd,preorderTraversal[i]);
		if(inorderIndex > -1)
		{
			return i;
		}
	}
	
	return -1;
}

int InOrderIndex(List<int> inorderTraversal, int iStart, int iEnd, int value)
{
	for(int i=iStart;i<=iEnd;i++)
	{
		if(value == inorderTraversal[i])
		{
			return i;
		}
	}
	
	return -1;
}