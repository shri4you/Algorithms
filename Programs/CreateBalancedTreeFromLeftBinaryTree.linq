<Query Kind="Program" />

void Main()
{
	TreeNode root = new TreeNode(15);
	var temp = root;
	for(int i=14;i>0;i--)
	{
		temp.Left = new TreeNode(i);
		temp = temp.Left;
	}
	
	MakeBalanced(root).Dump();
}

TreeNode MakeBalanced(TreeNode root)
{
	if(root == null || root.Left == null)
	{
		return root;
	}
	
	var mid = GetMid(root);
	mid.Left = MakeBalanced(mid.Left);
	mid.Right = MakeBalanced(root);
	return mid;
}

// Define other methods and classes here
TreeNode GetMid(TreeNode root)
{
	if(root == null)
		return root;
	
	TreeNode temp = null, s, f;
	temp = s = f = root;
	while(f != null &&f.Left != null)
	{
		temp = s;
		s=s.Left;
		f=f.Left.Left;
	}
	
	temp.Left = null;
	return s;
}