<Query Kind="Program" />

//	1. Reverse the linked list in pairs
//	Recursive and nonrecursive
//	Input - 1->2->3->4->X
//	Output- 2->1->4->3->X
void Main()
{
	LstNode root = new LstNode(0);
	LstNode f = root, n;
	for(int i = 1;i<11;i++)
	{
		n = new LstNode(i);
		f.next = n;
		f = n;
	}
	
	root.PrintList();
	LstNode.PairWiseReverse(root).PrintList();
}

public class LstNode
{
	public LstNode(int data)
	{
		this.Data = data;
	}
	
	public int Data;
	public LstNode next;
	
	public void PrintList()
	{
		LstNode l = this;
		while(l!=null)
		{
			Console.Write("{0} ",l.Data);
			l = l.next;
		}
		
		Console.WriteLine();
	}
	
	public static LstNode PairWiseReverse(LstNode root)
	{
		if(root == null || root.next == null)
		{
			return root;
		}
		
		var n = root.next;
		root.next = PairWiseReverse(n.next);
		n.next = root;
		return n;
	}
}

// Define other methods and classes here
