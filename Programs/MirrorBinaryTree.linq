<Query Kind="Program" />

public class Node
{
	public int Value {get;set;}
	public Node Left{get;set;}
	public Node Right{get;set;}
	
	public Node(int value)
	{
		this.Value = value;
	}
}

void Main()
{
	Node temp;
	Node root = new Node(5);
	Node left = new Node(4);
	Node right = new Node(7);
	
	temp = root;
	temp.Left = left;
	temp.Right = right;
	
	temp= root.Left;
	temp.Left= new Node(3);
	temp.Right = new Node(5);
	
	temp = root.Right;
	temp.Left = new Node(6);
	temp.Right = new Node(8);
	
	InOrder(root);
	
	Mirror(root);
	Console.WriteLine("Mirrored");
	InOrder(root);
}

void InOrder(Node root)
{
	if(root == null)
		return;
		
	InOrder(root.Left);
	Console.WriteLine(root.Value);
	InOrder(root.Right);
}

void Mirror(Node root)
{
	if(root ==null)
		return;
	
	Mirror(root.Left);
	Mirror(root.Right);
	Node temp = root.Left;
	root.Left = root.Right;
	root.Right = temp;
	
	
}

// Define other methods and classes here