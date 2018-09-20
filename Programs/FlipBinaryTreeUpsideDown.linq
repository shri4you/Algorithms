<Query Kind="Program" />

void Main()
{
	TreeNode t = new TreeNode(1);
	t.Left = new TreeNode(2);
	t.Right = new TreeNode(3);
	t.Left.Left = new TreeNode(4);
	t.Left.Right = new TreeNode(5);
	t.Left.Left.Left = new TreeNode(6);
	t.Left.Left.Right = new TreeNode(7);
	TreeNode n = t.Left.Left.Left;
	FlipTree(t, null, null, null).Dump();
}

TreeNode FlipTree(TreeNode root, TreeNode left, TreeNode right, TreeNode newRoot)
{
	if(root == null )
		return newRoot;
	
	newRoot = FlipTree(root.Left, root, root.Right, root.Left == null? root : root.Left);
	root.Right = left;
	root.Left = right;
	return newRoot;
}

// Define other methods and classes here
/*
http://www.careercup.com/question?id=6266917077647360
Given a binary tree where all the right nodes are leaf nodes, flip it upside down and turn it into a tree with left leaf nodes. 

Keep in mind: ALL RIGHT NODES IN ORIGINAL TREE ARE LEAF NODE.


* for example, turn these:
 *
 *        1                 1
 *       / \                 / \
 *      2   3            2   3
 *     / \
 *    4   5
 *   / \
 *  6   7
 *
 * into these:
 *
 *        1               1
 *       /               /
 *      2---3         2---3
 *     /
 *    4---5
 *   /
 *  6---7
 *
 * where 6 is the new root node for the left tree, and 2 for the right tree.
 * oriented correctly:
 *
 *     6                   2
 *    / \                   / \
 *   7   4              3   1
 *        / \
 *       5   2
 *            / \
 *          3   1
 */
