<Query Kind="Program" />




//4.1 Implement a function to check if a tree is balanced. 
// For the purposes of this question, a balanced tree is defined to be a tree such that no two leaf nodes differ in distance from the root by more than one.
int numberOfHeightCalls = 0;
void Main()
{
	TreeNode root = new TreeNode(1);
	root.Left = new TreeNode(2);
	root.Left.Left = new TreeNode(3);
	root.Left.Left.Left = new TreeNode(5);
	root.Right = new TreeNode(4);
	Console.WriteLine(isTreeBalanced(root));
	Console.WriteLine(numberOfHeightCalls);
}

// Define other methods and classes here
bool isTreeBalanced(TreeNode root)
{
	if(root == null)
		return true;
	return isTreeBalanced(root.Left) && isTreeBalanced(root.Right) && Math.Abs(height(root.Left) - height(root.Right)) <= 1;
}

int height(TreeNode root)
{
	numberOfHeightCalls = numberOfHeightCalls + 1;
	if(root == null)
		return 0;
	return 1 + Math.Max(height(root.Right), height(root.Left));
}