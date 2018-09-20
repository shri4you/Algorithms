<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var root = TreeNode.GetSampleTree(5);
	BFS(root);
}

// Define other methods and classes here
static void BFS(TreeNode root)
{
	Queue<TreeNode> q = new Queue<TreeNode>();
	TreeNode temp;
	q.Enqueue(root);
	q.Enqueue(null);
	int level = 1;
	Console.Write("Level {0}:",level);
	while (q.Any())
	{
		temp = q.Dequeue();
		if (temp == null)
		{
			if (!q.Any())
			{
				return;
			}
			else
			{
				level = level + 1;
				q.Enqueue(temp);
				Console.WriteLine();
				Console.Write("Level {0}:",level);
				continue;
				
	        }
		}

		Console.Write(temp.value);
		Console.Write(" ");
		if (temp.Left != null)
		{
			q.Enqueue(temp.Left);
		}

		if (temp.Right != null)
		{
			q.Enqueue(temp.Right);
		}
	}
}